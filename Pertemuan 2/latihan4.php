<!DOCTYPE html>
<html lang="en">
<head>
    <title>Form Inputan</title>
</head>
<body bgcolor="pink">
    <form action="hasil4.php"method="post">
        <table>
            <tr>
                <td><label for="panjang">Panjang</label></td>
                <td><input type="text" name="panjang" id="panjang"></td>
            </tr>
            <tr>
                <td><label for="">Lebar</label></td>
                <td><input type="text" name="lebar" id="lebar"></td>
            </tr>
            <tr>
                <td><label for="">tinggi</label></td>
                <td><input type="text" name="tinggi" id="tinggi"></td>
            </tr>
            <tr>
                <td colspan="2"><button type="submit" value ="hitung">Hitung Volume</button></td>
            </tr>
        </table>
    </form>
</body>
</html>