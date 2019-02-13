<html lang="ru">

 <head>
   <meta charset="utf-8">
   <meta http-equiv="refresh" content="300">
   <title>Интернет трафик</title>
   <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
   <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

 </head>

 <body>

 <center>
  <h1> Интернет-трафик </h1>
    <p><canvas id="canvas-in" style="width:75%"></canvas></p><hr>
    <p><canvas id="canvas-out" style="width:75%"></canvas></p><hr>
    <p><canvas id="canvas-circle" style="width:75%"></canvas></p><hr>
</center>

<?php

 # Текущая дата
 $cdate = date('Y-m-d');

 # Настройки БД
 $db_host = "localhost";
 $db_name = "DBNAME";
 $db_table = "DBTABLE"; 
 $db_user = "DBUSER";
 $db_pass = "DBPASSWORD";

 # Соединяемся с БД 
 $connection = mysql_connect($db_host, $db_user, $db_pass);
 mysql_select_db($db_name);
 mysql_query("SET NAMES UTF8");
 
 # Получаем список данных за день 
 $sql = "SELECT
            HOUR(tr_datetime) as hours,
            MINUTE(tr_datetime) as minutes,
            tr_ip,
            is_out,
            tr_count
        FROM $db_table 
        WHERE DATE(tr_datetime) = '$cdate'";
 $result = mysql_query($sql);
 $data = array();
 while($row = mysql_fetch_assoc($result)) 
 {
     $slice = array (
         'hour' => ( $row['hours'] < 10 ) ? "0".$row['hours'] : $row['hours'],
         'min'  => ( $row['minutes'] < 10 ) ? "0".$row['minutes'] : $row['minutes'],
         'ip' => $row['tr_ip'],
         'is_out' => $row['is_out'],
         'bytes' => $row['tr_count']         
     );
     array_push($data, $slice);
 }

 # Отключаемся от базы
 mysql_close($connection);

 # Подсчитываем часы
 $hours = array();
 foreach ($data as $slice) 
     $hours[$slice['hour'].":".$slice['min']] = 1;
 ksort($hours);
 
 # Посчитываем IP
 $ips = array();
 foreach ($data as $slice) 
     $ips[$slice['ip']] = 1;
 ksort($ips);

 # Итоговый массив
 $main = array();
 foreach($ips as $ip => $num)
  foreach ($hours as $hour => $num2)
  {
      $main[$ip][$hour]['bytes'] = 0;
      $main[$ip][$hour]['1'] = 0;
      $main[$ip][$hour]['0'] = 0;
  }
 foreach ($data as $slice)
 {
     $main[$slice['ip']][$slice['hour'].":".$slice['min']]['1'] = ($slice['is_out'] == 1) ? $slice['bytes']/1024/1024 : 0;
     $main[$slice['ip']][$slice['hour'].":".$slice['min']]['0'] = ($slice['is_out'] == 0) ? $slice['bytes']/1024/1024 : 0;
 }
 #print_r($main);

?>

<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>   
<script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.2/Chart.min.js"></script>

<script>

var config = {
    type: 'line',
    data: {
        labels: ['<?php echo join("', '", array_keys($hours)); ?>'],
        datasets: [
        <?php 
            $datasets = array();
            $color = 0;
            foreach($ips as $ip => $num)
            {
                $str = '{ ';
                $str .= "label: '$ip', \n";
                //$str .= "fill: false, \n";
                $str .= "backgroundColor: " . getColor($color) . ", \n";
                $str .= "borderColor: " . getColor($color) . ", \n";                 
                $color++;
                $str .= "data: [ \n";
                $hrs = array();
                foreach ($hours as $hour => $num2)
                    array_push($hrs, $main[$ip][$hour]['0']);
                $str .= join(', ',$hrs);
                $str .= " ]\n";
                $str .= " }\n";
                array_push($datasets, $str);
            }
            echo join(", ", $datasets);
         ?>
        ]},
    options: {
        responsive: true,
        title: {
            display: true,
            text: 'ВХОДЯЩИЙ ТРАФИК: Пиковая скорость за <?php echo $cdate; ?>'
            },
        tooltips: {
            mode: 'index',
            intersect: false,
            },
        hover: {
            mode: 'nearest',
            intersect: true
            },
        scales: {
            xAxes: [{
                    display: true,
                    scaleLabel: {
                        display: true,
                        labelString: 'Время'
                        }
                    
                }],
            yAxes: [{
                    display: true,
                    scaleLabel: {
                        display: true,
                        labelString: 'МБайт'
                        }
                    }]
            }
     }
    
};


var config2 = {
    type: 'line',
    data: {
        labels: ['<?php echo join("', '", array_keys($hours)); ?>'],
        datasets: [
        <?php 
            $datasets = array();
            $color = 0;
            foreach($ips as $ip => $num)
            {
                $str = '{ ';
                $str .= "label: '$ip', \n";
                //$str .= "fill: false, \n";
                $str .= "backgroundColor: " . getColor($color) . ", \n";
                $str .= "borderColor: " . getColor($color) . ", \n";                 
                $color++;
                $str .= "data: [ \n";
                $hrs = array();
                foreach ($hours as $hour => $num2)
                    array_push($hrs, $main[$ip][$hour]['1']);
                $str .= join(', ',$hrs);
                $str .= " ]\n";
                $str .= " }\n";
                array_push($datasets, $str);
            }
            echo join(", ", $datasets);
         ?>
        ]},
    options: {
        responsive: true,
        title: {
            display: true,
            text: 'ИСХОДЯЩИЙ ТРАФИК: Пиковая скорость за <?php echo $cdate; ?>'
            },
        tooltips: {
            mode: 'index',
            intersect: false,
            },
        hover: {
            mode: 'nearest',
            intersect: true
            },
        scales: {
            xAxes: [{
                    display: true,
                    scaleLabel: {
                        display: true,
                        labelString: 'Время'
                        }
                    
                }],
            yAxes: [{
                    display: true,
                    scaleLabel: {
                        display: true,
                        labelString: 'МБайт'
                        }
                    }]
            }
     }
    
};

var config3 = {
    type: 'pie',
    data: {
        labels: ['<?php echo join("', '", array_keys($ips)); ?>'],
        datasets: [{
                data: [
                    <?php
                      $all_traffic = array();
                      foreach($ips as $ip => $num)
                      {
                          $count = 0;
                          foreach( $hours as $hour => $num2)
                              $count = $count + $main[$ip][$hour]["0"];
                          array_push($all_traffic, round($count));
                      }
                      echo join(", ", $all_traffic);
                    ?>
                    ],
                backgroundColor: [
                    <?php
                    $colors = array();
                    $color = 0;
                    foreach($ips as $ip => $num)
                        array_push($colors, getColor($color++));
                    echo join(", ", $colors);
                    ?>
                    ],
                label: 'Общий объем трафика за день (МБайт)'
                }]
        
    },
    options: { 
        title: {
          display: true,
          text: 'Общий объем трафика за <?php echo $cdate; ?> (МБайт)'
        },
        responsive: true 
    }
    
};

window.onload = function() {
    var ctx1 = document.getElementById('canvas-in').getContext('2d');
    window.myLine = new Chart(ctx1, config);    

    var ctx2 = document.getElementById('canvas-out').getContext('2d');
    window.myLine = new Chart(ctx2, config2);    

    var ctx3 = document.getElementById('canvas-circle').getContext('2d');
    window.myPie = new Chart(ctx3, config3);

};

 </script>

 </body>
</html>
 
<?php
 function getColor($num) {
    $hash = md5('color' . $num); // modify 'color' to get a different palette
    return "'rgba(" .  hexdec(substr($hash, 0, 2)) . ","
                  .  hexdec(substr($hash, 2, 2)) . ","
                  .  hexdec(substr($hash, 4, 2)) . ", 1)'"; 
 }
?>
