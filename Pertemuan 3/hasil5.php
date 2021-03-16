<html>
    <body>
        <?php 
        $conn = mysqli_connect("localhost","root","root","5bmalamdb");
        if (mysqli_connect_errno()){
            echo "Koneksi Gagal".mysqli_connect_error();
        }
            $vNIM = $_POST['NIM'];
            $vnama =$_POST['nama'];
            $vemail = $_POST['email'];
            $valamat = $_POST['alamat'];
        $query = mysqli_query($conn, "insert into mahasiswa (NIM,nama,email,alamat) values('$vNIM','$vnama','$vemail','$valamat')");
        
        ?>
        terima kasih telah mendaftar
    </body>
</html>