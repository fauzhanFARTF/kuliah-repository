SELECT mhs.npm, mhs.nama, matakuliah.kmk, matakuliah.nama, nilai.nilai 
FROM mhs 
LEFT JOIN nilai ON mhs.npm = nilai.npm 
LEFT JOIN matakuliah ON matakuliah.kmk = nilai.kmk;