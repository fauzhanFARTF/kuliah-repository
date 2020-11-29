SELECT transaksi.id_transaksi, barang.kode_barang, barang.nama_barang, barang.harga, pembeli.nama_pembeli, pegawai.nama_pegawai 
FROM transaksi 
LEFT JOIN pembeli ON pembeli.id_pembeli = transaksi.id_pembeli 
LEFT JOIN pegawai ON pegawai.id_pegawai = transaksi.id_pegawai
LEFT JOIN barang ON barang.kode_barang = transaksi.kode_barang;