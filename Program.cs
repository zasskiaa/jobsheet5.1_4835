Console.Write("Masukkan Nama Anda: ");
String namaPelanggan = Console.ReadLine();

Console.Write("Jumlah halaman yang dicetak: ");
int jumlahHalaman = int.Parse(Console.ReadLine());

Console.Write("Harga cetak per halaman: ");
int hargaCetak = int.Parse(Console.ReadLine());

int totalBayar = jumlahHalaman * hargaCetak;
Console.WriteLine($"Total Bayar: {totalBayar}");

const int biayaAdmin = 2000;
Console.WriteLine("Biaya Administrasi: 2000");

int totalBiaya = totalBayar + biayaAdmin;
Console.WriteLine($"Total Biaya: {totalBiaya}");



