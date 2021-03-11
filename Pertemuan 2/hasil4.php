<!DOCTYPE html>
<html lang="en">
<head>
    <title>Hasil Volume</title>
</head>
<body  bgcolor="pink">
    <?php
    $vpanjang = $_POST['panjang'];
    $vlebar= $_POST['lebar'];
    $vtinggi= $_POST['tinggi'];
    $vvolume= $vpanjang * $vlebar * $vtinggi ;
    
    echo "Panjang = $vpanjang<br>";
    echo "Lebar = $vlebar<br>";
    echo "Tinggi = $vtinggi<br>";
    echo "Volume = $vvolume<br>";
    ?>


</body>
</html>

