using System;
class VAYTIEN
{
    #nullable disable
    public string tenkh;
    public int thoigianvay;
    public double tienvay,laixuatvay,tientra;
    public virtual void nhap()
    {
        Console.WriteLine("Nhap ten khach hang: ");
        tenkh=Console.ReadLine();
        Console.WriteLine("Nhap thoi gian vay: ");
        int.TryParse(Console.ReadLine(),out thoigianvay);
        Console.WriteLine("Nhap tien vay: ");
        double.TryParse(Console.ReadLine(), out tienvay);
        Console.WriteLine("Nhap lai xuat vay: ");
        double.TryParse(Console.ReadLine(), out laixuatvay);
        
    }
    public virtual void Tientra()
    {
        Console.WriteLine($"{tenkh},thoi gian vay {thoigianvay},tien vay {tienvay},lai xuat vay {laixuatvay} ");
    }
    
}
class VAYTINDUNG : VAYTIEN
{
    public double tienlaihangthang;
    public double hanmuc;
    public override void nhap()
    {
        base.nhap();
        Console.WriteLine("Nhap han muc: ");
        double.TryParse(Console.ReadLine(), out hanmuc);
    }
    public override void Tientra()
    {
        base.Tientra();
        Console.WriteLine($"han muc cua khach hang nay: {hanmuc}");
        if (tienvay<=hanmuc)
        {                
        if (thoigianvay<=1)
        {
            tientra=tienvay;
        }
        else 
        {
            tienlaihangthang=tienvay*laixuatvay/thoigianvay;
            tientra=(tienvay/thoigianvay) + tienlaihangthang;
        }
        }
        Console.WriteLine($"tien tra cua vay tin dung: {tientra}");
    }
}
class VAYTHECHAP: VAYTIEN
{
    public double giatrithechap;
    public double tienlaihangthang;
    public override void nhap()
    {
        base.nhap();
        Console.WriteLine("Nhap tri gia the chap: ");
        double.TryParse(Console.ReadLine(),out giatrithechap);
    }
    public override void Tientra()
    {
        base.Tientra();
        Console.WriteLine($"gia tri the chap cua khach hang nay: {giatrithechap}");
        if (tienvay<= 0.85* giatrithechap)
        {
            tienlaihangthang=tienvay*laixuatvay/thoigianvay;
            tientra= tienvay/thoigianvay + tienlaihangthang;
        }
        Console.WriteLine($"tien tra cua vay the chap: {tientra}");
    }
}
class VAYTHAUCHI: VAYTIEN
{
    public double tienluong;
    public double tienlaihangthang;
    public override void nhap()
    {
        base.nhap();
        Console.WriteLine("Nhap tien luong: ");
        double.TryParse(Console.ReadLine(), out tienluong);
    }
    public override void Tientra()
    {
        base.Tientra();
        Console.WriteLine($"Tien luong: {tienluong}");
        if (tienvay<= 10*tienluong)
        {
            tienlaihangthang=tienvay*laixuatvay/thoigianvay;
            tientra=tienvay/thoigianvay+tienlaihangthang;
        }
        Console.WriteLine($"Tien tra cua vay thau chi: {tientra}");
    }
}
class NGANHANG
{
    static void Main()
    {

        List<VAYTIEN> dskh =new List<VAYTIEN>();
        
        VAYTINDUNG a=new VAYTINDUNG{ tenkh="Tuan",hanmuc=600,tienvay=500,thoigianvay=3,laixuatvay=0.5};
        VAYTINDUNG b=new VAYTINDUNG{ tenkh="Tuan1",hanmuc=600,tienvay=500,thoigianvay=4,laixuatvay=0.6};
        VAYTINDUNG c=new VAYTINDUNG{ tenkh="Tuan2",hanmuc=600,tienvay=900,thoigianvay=2,laixuatvay=0.7};
        VAYTINDUNG d=new VAYTINDUNG{ tenkh="Tuan3",hanmuc=600,tienvay=800,thoigianvay=5,laixuatvay=0.8};
        VAYTINDUNG e=new VAYTINDUNG{ tenkh="Tuan4",hanmuc=600,tienvay=700,thoigianvay=6,laixuatvay=0.4};
        VAYTINDUNG f=new VAYTINDUNG{ tenkh="Tuan5",hanmuc=600,tienvay=500,thoigianvay=7,laixuatvay=0.3};
        VAYTINDUNG g=new VAYTINDUNG{ tenkh="Tuan6",hanmuc=600,tienvay=500,thoigianvay=9,laixuatvay=0.2};

        VAYTHECHAP vtc1=new VAYTHECHAP{tenkh="Han",tienvay=400,thoigianvay=2,laixuatvay=0.3,giatrithechap=1000};
        VAYTHECHAP vtc2=new VAYTHECHAP{tenkh="Han1",tienvay=400,thoigianvay=2,laixuatvay=0.3,giatrithechap=1000};
        VAYTHECHAP vtc3=new VAYTHECHAP{tenkh="Han2",tienvay=2000,thoigianvay=2,laixuatvay=0.3,giatrithechap=1000};

        VAYTHAUCHI vtcc1 =new VAYTHAUCHI{tenkh="V1",tienvay=30000,tienluong=1000,thoigianvay=2,laixuatvay=0.4};
        VAYTHAUCHI vtcc2 =new VAYTHAUCHI{tenkh="V1",tienvay=300,tienluong=1000,thoigianvay=2,laixuatvay=0.4};
        VAYTHAUCHI vtcc3 =new VAYTHAUCHI{tenkh="V1",tienvay=300,tienluong=1000,thoigianvay=2,laixuatvay=0.4};
        VAYTHAUCHI vtcc4 =new VAYTHAUCHI{tenkh="V1",tienvay=300,tienluong=1000,thoigianvay=2,laixuatvay=0.4};
        VAYTHAUCHI vtcc5 =new VAYTHAUCHI{tenkh="V1",tienvay=300,tienluong=1000,thoigianvay=2,laixuatvay=0.4};
        dskh.Add(a);
        dskh.Add(b);
        dskh.Add(c);
        dskh.Add(d);
        dskh.Add(e);
        dskh.Add(f);
        dskh.Add(g);
        dskh.Add(vtc1);
        dskh.Add(vtc2);
        dskh.Add(vtc3);
        dskh.Add(vtcc1);
        dskh.Add(vtcc2);
        dskh.Add(vtcc3);
        dskh.Add(vtcc4);
        dskh.Add(vtcc5);
        foreach (var khachhang in dskh)
        {
            if (khachhang is VAYTINDUNG)
            {
                VAYTINDUNG vaytindung = (VAYTINDUNG)khachhang;
                if (vaytindung.tienvay > vaytindung.hanmuc)
                {
                    Console.WriteLine($"Ho so khong hop le cua vay tin dung: {vaytindung.tenkh}");
                }
            }
            else if (khachhang is VAYTHECHAP)
            {
                VAYTHECHAP vaythechap = (VAYTHECHAP)khachhang;
                if (vaythechap.tienvay > 0.85 * vaythechap.giatrithechap)
                {
                    Console.WriteLine($"Ho so khong hop le vay the chap: {vaythechap.tenkh}");
                }
            }
            else if (khachhang is VAYTHAUCHI)
            {
                VAYTHAUCHI vaythauchi = (VAYTHAUCHI)khachhang;
                if (vaythauchi.tienvay > 10 * vaythauchi.tienluong)
                {
                    Console.WriteLine($"Ho so khong hop le vay thau chi: {vaythauchi.tenkh}");
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("thong tin khach hang co ho so hop le: ");
        foreach (var khachhang in dskh)
        {
            if (khachhang is VAYTINDUNG)
            {               
                VAYTINDUNG vaytindung = (VAYTINDUNG)khachhang;
                if (vaytindung.tienvay <= vaytindung.hanmuc)
                {
                    Console.WriteLine($"Thong tin khach hang: {vaytindung.tenkh}");
                    vaytindung.Tientra();
                }
            }
            else if (khachhang is VAYTHECHAP)
            {                
                VAYTHECHAP vaythechap = (VAYTHECHAP)khachhang;
                if (vaythechap.tienvay <= 0.85 * vaythechap.giatrithechap)
                {
                    Console.WriteLine($"Thong tin khach hang: {vaythechap.tenkh}");
                    vaythechap.Tientra();
                }
            }
            else if (khachhang is VAYTHAUCHI)
            {               
                VAYTHAUCHI vaythauchi = (VAYTHAUCHI)khachhang;
                if (vaythauchi.tienvay <= 10 * vaythauchi.tienluong)
                {
                    Console.WriteLine($"Thong tin khach hang: {vaythauchi.tenkh}");
                    vaythauchi.Tientra();
                }
            }
        }
    }
}