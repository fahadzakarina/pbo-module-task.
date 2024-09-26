using System;
using System.Collections.Generic;

// Kelas dasar: Hewan
public class Hewan
{
    public string Nama { get; set; }
    public int Umur { get; set; }

    public Hewan(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }

    public virtual string Suara()
    {
        return "Hewan ini memiliki suara.";
    }

    public virtual string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur} tahun";
    }
}

// Subkelas: Mamalia
public class Mamalia : Hewan
{
    public int JumlahKaki { get; set; }

    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        JumlahKaki = jumlahKaki;
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Jumlah Kaki: {JumlahKaki}";
    }
}

// Subkelas: Reptil
public class Reptil : Hewan
{
    public double PanjangTubuh { get; set; }

    public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
    {
        PanjangTubuh = panjangTubuh;
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Panjang Tubuh: {PanjangTubuh} meter";
    }
}

// Subkelas: Singa
public class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki) { }

    public override string Suara()
    {
        return "Singa mengeluarkan suara auman!";
    }

    public void Mengaum()
    {
        Console.WriteLine($"{Nama} mengaum dengan keras!");
    }
}

// Subkelas: Gajah
public class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki) { }

    public override string Suara()
    {
        return "Gajah mengeluarkan suara deruman.";
    }
}

// Subkelas: Ular
public class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override string Suara()
    {
        return "Ular mendesis.";
    }

    public void Merayap()
    {
        Console.WriteLine($"{Nama} sedang merayap di tanah.");
    }
}

// Subkelas: Buaya
public class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override string Suara()
    {
        return "Buaya mengeluarkan suara eraman.";
    }
}

// Kelas Kebun Binatang
public class KebunBinatang
{
    private List<Hewan> koleksiHewan;

    public KebunBinatang()
    {
        koleksiHewan = new List<Hewan>();
    }

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
        Console.WriteLine($"{hewan.Nama} telah ditambahkan ke kebun binatang.");
    }

    public void DaftarHewan()
    {
        Console.WriteLine("\nDaftar Hewan di Kebun Binatang:");
        foreach (var hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Membuat objek kebun binatang
        KebunBinatang kebunBinatang = new KebunBinatang();

        // Membuat objek hewan dari berbagai jenis
        Singa singa = new Singa("Leo", 8, 4);
        Gajah gajah = new Gajah("Ele", 10, 4);
        Ular ular = new Ular("Cobra", 3, 2.5);
        Buaya buaya = new Buaya("Luca", 6, 4.2);

        // Menambahkan hewan ke kebun binatang
        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        // Menampilkan daftar hewan di kebun binatang
        kebunBinatang.DaftarHewan();

        // Demonstrasi Polymorphism
        Console.WriteLine("\nDemonstrasi Polymorphism:");
        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine(buaya.Suara());

        // Aksi Khusus
        Console.WriteLine("\nAksi Khusus:");
        singa.Mengaum();
        ular.Merayap();
    }
}
