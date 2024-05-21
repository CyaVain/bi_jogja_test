SELECT 
	t.KODE, t.TANGGAL , 
	p.NAMA as "NAMA PELANGGAN", 
    b.NAMA as "NAMA BARANG", 
    t.JUMLAH_BARANG as "JUMLAH", 
    b.HARGA as "HARGA SATUAN", 
    t.JUMLAH_BARANG * b.HARGA as "TOTAL"
FROM transaksi t
JOIN pelanggan p ON t.KODE_PELANGGAN = p.KODE
JOIN barang b on t.KODE_BARANG = b.KODE
ORDER BY 
	p.NAMA ASC, 
	t.Tanggal ASC;