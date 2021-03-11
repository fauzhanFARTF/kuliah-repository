<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    $vjumlah = $_POST['jml'];
    $vharga= $_POST['hrg'];
    $vbayar= $vjumlah * $vharga ;
    
    echo "Jumlah = $vjumlah<br>";
    echo "Harga = $vharga<br>";
    echo "Bayar = $vbayar<br>";
    ?>
</body>
</html>

