using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCorePBI.Controllers
{
    public class Pedidos
    {
        public string NumPedido { get; set; }
        public string CodCliente { get; set; }
        public DateTime DataPedido { get; set; }
        public string CodItem { get; set; }
        public decimal Desconto { get; set; }
        public int Qtde { get; set; }
        public decimal Preco { get; set; }

        public static List<Pedidos> LerPedidos()
        {
            // ler as informações dos pedidos 
            return new List<Pedidos>
            {
                new Pedidos {NumPedido="10000", CodCliente="Cliente O557", DataPedido=new DateTime(2016,07,02), CodItem="MT1841", Desconto=0, Qtde=94, Preco=1299.9M },
                new Pedidos {NumPedido="10011", CodCliente="Cliente O533", DataPedido=new DateTime(2016,08,27), CodItem="WC1984", Desconto=0, Qtde=50, Preco=129.9M },
                new Pedidos {NumPedido="10013", CodCliente="Cliente O144", DataPedido=new DateTime(2017,01,15), CodItem="SM1163", Desconto=0, Qtde=69, Preco=139.9M },
                new Pedidos {NumPedido="10015", CodCliente="Cliente O493", DataPedido=new DateTime(2017,01,05), CodItem="SM1252", Desconto=0, Qtde=42, Preco=79.9M },
                new Pedidos {NumPedido="10018", CodCliente="Cliente O552", DataPedido=new DateTime(2016,03,11), CodItem="NK1121", Desconto=0, Qtde=36, Preco=2359.9M },
                new Pedidos {NumPedido="10038", CodCliente="Cliente O507", DataPedido=new DateTime(2016,04,15), CodItem="SF1688", Desconto=0, Qtde=18, Preco=199.9M },
                new Pedidos {NumPedido="10049", CodCliente="Cliente O473", DataPedido=new DateTime(2017,07,13), CodItem="SM1086", Desconto=0, Qtde=64, Preco=98.9M },
                new Pedidos {NumPedido="10056", CodCliente="Cliente O538", DataPedido=new DateTime(2016,04,18), CodItem="SF1999", Desconto=0, Qtde=34, Preco=199.9M },
                new Pedidos {NumPedido="10066", CodCliente="Cliente O471", DataPedido=new DateTime(2017,06,30), CodItem="SM1200", Desconto=0, Qtde=35, Preco=79.9M },
                new Pedidos {NumPedido="10075", CodCliente="Cliente O558", DataPedido=new DateTime(2016,01,13), CodItem="SM1897", Desconto=0, Qtde=70, Preco=59.9M },
                new Pedidos {NumPedido="10083", CodCliente="Cliente O586", DataPedido=new DateTime(2017,03,03), CodItem="CA1133", Desconto=0, Qtde=14, Preco=29.9M },
                new Pedidos {NumPedido="10087", CodCliente="Cliente O578", DataPedido=new DateTime(2017,02,15), CodItem="PC1278", Desconto=0, Qtde=90, Preco=2599.9M },
                new Pedidos {NumPedido="10103", CodCliente="Cliente O161", DataPedido=new DateTime(2016,11,14), CodItem="PC1078", Desconto=0, Qtde=72, Preco=3199.9M },
                new Pedidos {NumPedido="10122", CodCliente="Cliente O530", DataPedido=new DateTime(2017,07,08), CodItem="MT1733", Desconto=0, Qtde=21, Preco=799.9M },
                new Pedidos {NumPedido="10130", CodCliente="Cliente O576", DataPedido=new DateTime(2016,01,08), CodItem="SF1828", Desconto=0, Qtde=42, Preco=599.9M },
                new Pedidos {NumPedido="10131", CodCliente="Cliente O489", DataPedido=new DateTime(2016,02,25), CodItem="WC1053", Desconto=0, Qtde=47, Preco=329.9M },
                new Pedidos {NumPedido="10143", CodCliente="Cliente O547", DataPedido=new DateTime(2017,06,09), CodItem="CA1145", Desconto=0, Qtde=52, Preco=29.9M },
                new Pedidos {NumPedido="10157", CodCliente="Cliente O538", DataPedido=new DateTime(2016,01,12), CodItem="MS1542", Desconto=0, Qtde=46, Preco=39.9M },
                new Pedidos {NumPedido="10164", CodCliente="Cliente O478", DataPedido=new DateTime(2017,02,11), CodItem="WC1295", Desconto=0, Qtde=73, Preco=219.9M },
                new Pedidos {NumPedido="10168", CodCliente="Cliente O557", DataPedido=new DateTime(2016,04,17), CodItem="MS1458", Desconto=0, Qtde=28, Preco=59.9M },
                new Pedidos {NumPedido="10171", CodCliente="Cliente O453", DataPedido=new DateTime(2016,10,18), CodItem="WC1617", Desconto=0, Qtde=62, Preco=329.9M },
                new Pedidos {NumPedido="10176", CodCliente="Cliente O489", DataPedido=new DateTime(2016,07,21), CodItem="CA1372", Desconto=0, Qtde=38, Preco=48.9M },
                new Pedidos {NumPedido="10180", CodCliente="Cliente O505", DataPedido=new DateTime(2017,03,19), CodItem="PC1476", Desconto=0, Qtde=72, Preco=3599.9M },
                new Pedidos {NumPedido="10194", CodCliente="Cliente O485", DataPedido=new DateTime(2017,03,07), CodItem="PC1468", Desconto=0, Qtde=56, Preco=3199.9M },
                new Pedidos {NumPedido="10196", CodCliente="Cliente O542", DataPedido=new DateTime(2017,04,14), CodItem="NK1176", Desconto=0, Qtde=57, Preco=3899.9M },
                new Pedidos {NumPedido="10200", CodCliente="Cliente O510", DataPedido=new DateTime(2016,11,04), CodItem="PC1760", Desconto=0, Qtde=29, Preco=2599.9M },
                new Pedidos {NumPedido="10207", CodCliente="Cliente O514", DataPedido=new DateTime(2016,09,07), CodItem="SF1828", Desconto=0, Qtde=10, Preco=599.9M },
                new Pedidos {NumPedido="10210", CodCliente="Cliente O494", DataPedido=new DateTime(2016,04,19), CodItem="PC1048", Desconto=0, Qtde=29, Preco=2599.9M },
                new Pedidos {NumPedido="10211", CodCliente="Cliente O475", DataPedido=new DateTime(2016,06,02), CodItem="PC1950", Desconto=0, Qtde=55, Preco=4199.9M },
            };
        }
    }
}
