ALTER TABLE jadwalajar ADD CONSTRAINT fk_dosen FOREIGN KEY (nidn) REFERENCES dosen(nidn);
ALTER TABLE jadwalajar ADD CONSTRAINT fk_kelas FOREIGN KEY (kelas) REFERENCES kelas(kelas);