namespace basics.Models
{
    public class Repository{
        private static readonly List<Seyahat>
        _seyahat=new List<Seyahat>();


        static Repository(){
            _seyahat=new List<Seyahat>(){
                new Seyahat(){
            Id=1,Tittle="Prag Tatili",Bilgi="3 gece 4 gün",Fiyat= "1700$",Image="5.jpeg",Tags=new string[]{"Konaklama Masrafları",
            "Gezi rehberi",
            }, isActive=true, isHome=true},
            new Seyahat(){
            Id=2,Tittle="Paris Tatili",Bilgi="6 gece 7 gün",Fiyat= "2600$",Image="2.jpeg",Tags=new string[]{"Konaklama Masrafları",
            "Gezi rehberi",
            }, isActive=true, isHome=false},
            new Seyahat(){
            Id=3,Tittle="Londra Tatili",Bilgi="2 gece 3 gün",Fiyat= "1400$",Image="3.jpeg",Tags=new string[]{"Konaklama Masrafları",
            "Gezi rehberi",
            }, isActive=true, isHome=true},
            new Seyahat(){
            Id=4,Tittle="İstanbul Tatili",Bilgi="4 gece 5 gün",Fiyat= "1800$",Image="4.jpeg",Tags=new string[]{"Konaklama Masrafları",
            "Gezi rehberi",
            }, isActive=true, isHome=true},
            new Seyahat(){
            Id=5,Tittle="Bangkok Tatili",Bilgi="3 gece 4 gün",Fiyat= "1900$",Image="7.jpeg",Tags=new string[]{"Konaklama Masrafları",
            "Gezi rehberi",
            }, isActive=true, isHome=false},
            new Seyahat(){
            Id=6,Tittle="Venedik Tatili",Bilgi="3 gece 4 gün",Fiyat= "1500$",Image="1.jpeg",Tags=new string[]{"Konaklama Masrafları",
            "Gezi rehberi",
            }, isActive=true, isHome=true}


            };
        }

        public static List<Seyahat> Seyahats{
            get{
                return _seyahat;
            }
        }
        public static Seyahat? GetById(int? id ){
            return _seyahat.FirstOrDefault(s => s.Id == id);
        }
    }
}