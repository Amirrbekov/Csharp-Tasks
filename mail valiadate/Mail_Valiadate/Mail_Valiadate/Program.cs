/*
 @ işaretinden önce sayısal değer yer alamaz. 
mail içerisinde . hariç özel karakter yer alamaz , - _ vb. . ile değiştiriniz. @ işaretinden önceki kısım içerisinde sadece 1 adet . işareti yer alabilir.

vi.rgie@yahoo.com @ işareti öncesinde . işareti olmadığı için valid bir mail adresi değildir.
mail adresleri içerisinde yer alan bilgileri ayrıştırınız
        
            FirstName   : vi
            LastName    : rgie
            Mail        : vi.rgie@yahoo.com
            Domain      : yahoo
            Extention   : com

            --------------------------------------------

            FirstName   : vi
            LastName    : rgie
            Mail        : vi.rgie@yahoo.com
            Domain      : yahoo
            Extention   : com

            --------------------------------------------
 */

string[] mails =
{
    "justina.nienow91@yahoo.com",
    "emmet4@hotmail.com",
    "ara42@gmail.com",
    "domenic.padberg@yahoo.com",
    "arno.collier42@yahoo.com",
    "aurelia_botsford@gmail.com",
    "hettie.runte@gmail.com",
    "allen.thompson6@gmail.com",
    "piper56@hotmail.com",
    "jessy_witting47@gmail.com",
    "adolph93@yahoo.com",
    "lea_homenick40@hotmail.com",
    "delbert_gislason73@hotmail.com",
    "minerva73@gmail.com",
    "jacklyn.greenfelder@gmail.com",
    "kira.stokes@hotmail.com",
    "albin.wisozk@gmail.com",
    "tyrese.ritchie9@hotmail.com",
    "austyn66@gmail.com",
    "amani.kilback@yahoo.com",
    "leopold.mraz86@hotmail.com",
    "terrence_kilback89@hotmail.com",
    "abdiel.willms@hotmail.com",
    "aniyah30@gmail.com",
    "blake.bradtke64@hotmail.com",
    "darien.torp@hotmail.com",
    "jayne.heathcote@yahoo.com",
    "miles65@yahoo.com",
    "humberto.schmeler47@hotmail.com",
    "maida.fritsch@gmail.com",
    "freddie.lindgren95@gmail.com",
    "general1@gmail.com",
    "reinhold_west@gmail.com",
    "deion_kulas14@hotmail.com",
    "johnnie2@hotmail.com",
    "clark_kub9@gmail.com",
    "nikki_donnelly30@gmail.com",
    "june25@hotmail.com",
    "rollin.koch37@gmail.com",
    "aliyah.senger@hotmail.com",
    "kayli.bergstrom@hotmail.com",
    "nikko93@gmail.com",
    "queen.rippin41@yahoo.com",
    "lafayette13@hotmail.com",
    "reyes.beatty@gmail.com",
    "ford_kessler@gmail.com",
    "lennie70@gmail.com",
    "diego41@gmail.com",
    "theresia_becker@hotmail.com",
    "niko_mayer85@yahoo.com",
    "evans30@gmail.com",
    "jackeline_bailey20@hotmail.com",
    "zoe83@hotmail.com",
    "lucius.gibson18@gmail.com",
    "ibrahim_gaylord69@hotmail.com",
    "elenora98@hotmail.com",
    "davonte60@gmail.com",
    "dawson.fritsch0@gmail.com",
    "felton_jenkins@hotmail.com",
    "brown.bradtke@yahoo.com",
    "arturo.bosco1@yahoo.com",
    "mervin.leffler@gmail.com",
    "kitty33@gmail.com",
    "colby_pfeffer22@gmail.com",
    "orie.pfannerstill0@gmail.com",
    "natalie.mckenzie28@yahoo.com",
    "eulalia.vonrueden10@hotmail.com",
    "tiana94@hotmail.com",
    "clifford80@hotmail.com",
    "shaylee.grimes@hotmail.com",
    "jamey22@hotmail.com",
    "caden_hane12@yahoo.com",
    "abdiel_oconnell@yahoo.com",
    "foster69@hotmail.com",
    "kassandra_douglas@yahoo.com",
    "mireille11@yahoo.com",
    "laila_pfannerstill18@hotmail.com",
    "luciano84@hotmail.com",
    "michel54@gmail.com",
    "mariano_waelchi@gmail.com",
    "rodger_padberg82@yahoo.com",
    "dagmar.rowe56@gmail.com",
    "johnny47@gmail.com",
    "bernice_kemmer81@gmail.com",
    "josiane90@gmail.com",
    "porter14@yahoo.com",
    "haley7@yahoo.com",
    "randall93@hotmail.com",
    "elvie17@yahoo.com",
    "lizeth_hermiston@yahoo.com",
    "tremaine_oconnell73@hotmail.com",
    "ines52@gmail.com",
    "marco.hickle61@gmail.com",
    "muhammad_lebsack29@yahoo.com",
    "kaley45@gmail.com",
    "bret66@hotmail.com",
    "kaylie60@hotmail.com",
    "oral83@yahoo.com",
    "lilliana18@yahoo.com",
    "gilbert.dietrich72@hotmail.com",
    "norris.emmerich@gmail.com",
    "nina.smith@gmail.com",
    "kurtis.goyette18@hotmail.com",
    "deshawn.reichert@gmail.com",
    "montana10@gmail.com",
    "korbin6@hotmail.com",
    "leonel_sipes@yahoo.com",
    "peyton_wehner57@yahoo.com",
    "uriah.daugherty@yahoo.com",
    "juwan.kemmer@gmail.com",
    "alverta.shanahan@hotmail.com",
    "shanny0@yahoo.com",
    "virgie50@yahoo.com",
    "everett61@yahoo.com",
    "idell.schinner@hotmail.com",
    "leon_kautzer@hotmail.com",
    "adella_brown@gmail.com",
    "caden.oconner79@yahoo.com",
    "karli_macejkovic60@gmail.com",
    "dejuan_ortiz5@yahoo.com",
    "shyann.hodkiewicz84@hotmail.com",
    "elias_wehner37@yahoo.com",
    "rodolfo.crooks13@hotmail.com",
    "mateo49@gmail.com",
    "kallie94@gmail.com",
    "ian.lynch@hotmail.com",
    "don_wilderman@hotmail.com",
    "kristoffer.aufderhar48@yahoo.com",
    "ova_williamson68@gmail.com",
    "mitchell_beier@gmail.com",
    "ola_skiles75@hotmail.com",
    "godfrey_zulauf@gmail.com",
    "tobin_williamson@hotmail.com",
    "jackeline54@hotmail.com",
    "darrick.gleichner99@gmail.com",
    "krystina73@gmail.com",
    "meagan.koepp@gmail.com",
    "rogers.schultz44@hotmail.com",
    "winona_feil@yahoo.com",
    "lon.ritchie8@gmail.com",
    "zachariah_halvorson90@yahoo.com",
    "brody11@hotmail.com",
    "kiera11@yahoo.com",
    "donna.maggio@hotmail.com",
    "ciara42@gmail.com",
    "lilly.sauer@hotmail.com",
    "stan_parker@hotmail.com",
    "nelle.predovic@hotmail.com",
    "dawson70@hotmail.com",
    "raegan1@gmail.com",
    "finn14@hotmail.com",
    "lourdes_west@gmail.com",
    "donavon_davis@yahoo.com",
    "brielle.herman@hotmail.com",
    "janae_sipes42@yahoo.com",
    "jarret_morar@gmail.com",
    "cathy.johnson@yahoo.com",
    "winfield.ullrich@hotmail.com",
    "stephania.grant25@yahoo.com",
    "benedict.denesik55@yahoo.com",
    "charley58@hotmail.com",
    "marisa.gerlach@gmail.com",
    "gerry_baumbach@gmail.com",
    "emil_carter20@gmail.com",
    "torey.lemke@yahoo.com",
    "westley.hettinger1@yahoo.com",
    "enos_kreiger@hotmail.com",
    "keely22@gmail.com",
    "edwina_gutmann90@gmail.com",
    "shemar52@yahoo.com",
    "savion_bosco8@gmail.com",
    "ly.da76@yahoo.com",
    "kaitlyn.hayes13@gmail.com",
    "demetrius28@gmail.com",
    "briana_renner13@gmail.com",
    "coleman85@yahoo.com",
    "maddison_walker@gmail.com",
    "dorthy.wisoky14@hotmail.com",
    "randal.orn10@gmail.com",
    "conrad.marvin23@hotmail.com",
    "brendon_langosh@hotmail.com",
    "floy95@gmail.com",
    "kelvin52@yahoo.com",
    "therese.waters62@yahoo.com",
    "chase_schinner@hotmail.com",
    "tyree95@gmail.com",
    "jarvis36@hotmail.com",
    "maximo_krajcik77@hotmail.com",
    "burdette.koelpin13@gmail.com",
    "christina_considine29@yahoo.com",
    "merle57@gmail.com",
    "walton84@yahoo.com",
    "mckenzie57@gmail.com",
    "susanna.dubuque30@yahoo.com",
    "elody_davis99@hotmail.com",
    "lula.dibbert9@gmail.com",
    "kareem42@gmail.com",
    "daryl97@hotmail.com",
    "doug_herman81@gmail.com",
    "winnifred56@yahoo.com"
};
string[] vermails = new string[0];
foreach (var mailsItem in mails)
{
    string newmail = mailsItem.Remove(mailsItem.LastIndexOf("@")).Replace('-', '.')
                                                                 .Replace('_', '.');
    string domainmail = mailsItem.Substring(mailsItem.LastIndexOf("@"));
    do
    {
        newmail = newmail.Remove(newmail.LastIndexOf(newmail[newmail.Length - 1]));
    } while (char.IsDigit(newmail.Last()));

    for (int i = 0; i < newmail.Length; i++)
    {
        if (!Char.IsLetterOrDigit(newmail[i]) && newmail.IndexOf('.') == newmail.LastIndexOf('.'))
        {
            Array.Resize(ref vermails, vermails.Length + 1);
            vermails[vermails.Length - 1] = newmail + domainmail;
        }
    }
}

foreach (var mail in vermails)
{
    Console.WriteLine(
        $"FirstName : {mail.Remove(mail.IndexOf("."))} \n" + $"LastName  : {mail.Substring(mail.IndexOf(".") + 1, mail.LastIndexOf("@") - mail.IndexOf(".") - 1)} \n" + $"Mail      : {mail} \n" + $"Domain    : {mail.Substring(mail.LastIndexOf("@")+1, mail.LastIndexOf(".") - mail.LastIndexOf("@") - 1)} \n" + $"Extention : {mail.Substring(mail.LastIndexOf(".") + 1)} \n");
    Console.WriteLine("---------------------");
}