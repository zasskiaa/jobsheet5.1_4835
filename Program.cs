Console.WriteLine("=== RINCIAN PENCETAKAN ===");

Console.Write("Nama Pelanggan: ");
String namaPelanggan = Console.ReadLine();

Console.Write("Jumlah halaman: ");
int jumlahHalaman = int.Parse(Console.ReadLine());

Console.Write("Harga per halaman: ");
int hargaCetak = int.Parse(Console.ReadLine());

int subTotal = jumlahHalaman * hargaCetak;
Console.WriteLine($"Sub Total: {subTotal}");

const int biayaAdmin = 2000;
Console.WriteLine("Biaya Administrasi: 2000");

int totalBayar = totalBiaya + biayaAdmin;
Console.WriteLine($"Total Bayar: {totalBayar}");



