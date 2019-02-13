require 'streamio-ffmpeg'

class VideoProcessor

	def initialize(filename_in:, filename_out:, time_from:, time_to:)
		@filename_in = filename_in
		@filename_out = filename_out
	        @time_from = time_from
		@time_to = time_to

		@thread = nil 
	end

        def start
          if @thread.nil? then
            @thread = Thread.new { self.process }
          end
        end

        def status
          if @thread.nil? then
            false
          else
            @thread.status
          end
        end

        def stop
          return if @thread.nil?
          @thread.kill
          @thread = nil
        end
        
	def process
	  video = FFMPEG::Movie.new(@filename_in)
	  options = %w( -b:v 500k -b:a 128k -c:v libx264 -c:a aac -vf scale=1280:720 )
          options += %W( -ss #{@time_from} -to #{@time_to})
	  video.transcode(@filename_out, options)
	end
end
