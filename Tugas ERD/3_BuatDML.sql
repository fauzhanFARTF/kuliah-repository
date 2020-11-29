INSERT INTO pembeli (id_pembeli, nama_pembeli, alamat, no_telp) VALUES 
('A00001','Ari','Jl. Raya Peusar RT. 02/14 Desa Cikupa Kecamatan Cikupa ','081270770764');
INSERT INTO barang (kode_barang, nama_barang, harga, stok) VALUES 
('B1001','Shampo Sunsilk', 12800, 30);
INSERT INTO pegawai(id_pegawai, nama_pegawai) VALUES 
('3271060001','Rina');
INSERT INTO transaksi(id_pembeli, id_pegawai, kode_barang, id_transaksi, tgl_transaksi) VALUES 
('A00001','3271060001', 'B1001', '29112020001', 2020-11-29);