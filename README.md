```
.simple DriveThru App
abandoned, since this is only a school project
Minimum screen resolution: 1920x1080 (1080p). Lower resolutions may cause UI misalignment.
```

insert this sqlquery 
```
-- Tabel kasir
CREATE TABLE kasir (
    id_kasir INT NOT NULL PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(100) NOT NULL
);

-- Tabel menu
CREATE TABLE menu (
    id_menu INT NOT NULL PRIMARY KEY,
    nama_menu VARCHAR(100) NOT NULL,
    harga INT NOT NULL,
    kategori VARCHAR(50) NOT NULL,
    gambar LONGBLOB
);

-- Tabel transaksi
CREATE TABLE transaksi (
    id_transaksi INT NOT NULL PRIMARY KEY,
    tanggal DATETIME NOT NULL,
    nama_kasir VARCHAR(50) NOT NULL,
    metode_bayar VARCHAR(20) NOT NULL,
    total_bayar DECIMAL(15,2) NOT NULL
);

-- Tabel transaksi_detail
CREATE TABLE transaksi_detail (
    id_detail INT NOT NULL PRIMARY KEY,
    id_transaksi INT NOT NULL,
    item VARCHAR(100) NOT NULL,
    qty INT NOT NULL,
    harga_satuan DECIMAL(15,2) NOT NULL,
    total DECIMAL(15,2) NOT NULL
    -- FOREIGN KEY (id_transaksi) REFERENCES transaksi(id_transaksi) -- opsional, jika ingin relasi
);

-- Tabel users 
CREATE TABLE users (
    id INT NOT NULL PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(100) NOT NULL,
    level VARCHAR(20) NOT NULL
);

```
-khzx
