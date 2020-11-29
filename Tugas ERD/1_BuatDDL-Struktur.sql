CREATE TABLE pembeli( id_pembeli CHAR(8) PRIMARY KEY, nama_pembeli CHAR(30), alamat CHAR(30), no_telp CHAR (15));
CREATE TABLE barang(kode_barang CHAR(8) PRIMARY KEY, nama_barang CHAR(30), harga INTEGER, stok INTEGER);
CREATE TABLE pegawai(id_pegawai CHAR(8) PRIMARY KEY, nama_pegawai CHAR(30));
CREATE TABLE transaksi(id_pembeli CHAR(8),  id_pegawai CHAR(8), kode_barang CHAR(8), id_transaksi CHAR(8), tgl_transaksi DATE);