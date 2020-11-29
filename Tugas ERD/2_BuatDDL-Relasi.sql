ALTER TABLE transaksi ADD CONSTRAINT fk_pembeli FOREIGN KEY (id_pembeli) REFERENCES pembeli(id_pembeli);
ALTER TABLE transaksi ADD CONSTRAINT fk_kodebarang FOREIGN KEY (kode_barang) REFERENCES barang(kode_barang);
ALTER TABLE transaksi ADD CONSTRAINT fk_pegawai FOREIGN KEY (id_pegawai) REFERENCES pegawai(id_pegawai);