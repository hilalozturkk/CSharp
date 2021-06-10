using System;
using System.Collections.Generic;

namespace TelefonRehberiUygulamasi
{
	class Program
	{
		static void Main(string[] args)
		{

			TelefonRehberi telefon = new TelefonRehberi();


			telefon.KisiEkle("Ayşe", "Yılmaz", 543777777);
			telefon.KisiEkle("İbrahim", "Yılmaz", 543111111);
			telefon.KisiEkle("Hakan", "Yılmaz", 543999999);
			telefon.KisiEkle("Elif", "Yılmaz", 543666666);
			telefon.KisiEkle("Hilal", "Yılmaz", 543333333);
			telefon.Yazdir();

			Console.WriteLine("Sayı girişi yapınız:)");
			Console.WriteLine("******************************\n");

			Console.WriteLine(
			"(1) Yeni Numara Kaydetmek\n" +
			"(2) Varolan Numarayı Silmek\n" +
			"(3) Varolan Numarayı Güncelleme\n" +
			"(4) Rehberi Listelemek\n" +
			"(5) Rehberde Arama Yapmak"
			);

			string isim, soyisim;
			int numara;

			int secenek = Convert.ToInt32(Console.ReadLine());

			switch (secenek)
			{
				case 1:

					Console.WriteLine("İsminizi girin");
					isim = Console.ReadLine();

					Console.WriteLine("Soyisminizi girin");
					soyisim = Console.ReadLine();

					Console.WriteLine("Numaranızı girin");
					numara = Convert.ToInt32(Console.ReadLine().ToString());

					telefon.KisiEkle(isim, soyisim, numara);

					telefon.Yazdir();
					break;




				case 2:

					Console.WriteLine("İsminizi girin");
					isim = Console.ReadLine();

					Console.WriteLine("Soyisminizi girin");
					soyisim = Console.ReadLine();

					if (telefon.KisiVarmi(isim, soyisim))
					{
						telefon.KisiSil(isim, soyisim);
						telefon.Yazdir();
					}

					else
					{
						Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n" +
			 "* Silmeyi sonlandırmak için : (1)\n" +
			 "* Yeniden denemek için      : (2)");

						secenek = Convert.ToInt32(Console.ReadLine());
						if (secenek == 2)
						{
							Console.WriteLine("İsminizi girin");
							isim = Console.ReadLine();

							Console.WriteLine("Soyisminizi girin");
							soyisim = Console.ReadLine();

							if (telefon.KisiVarmi(isim, soyisim))
							{
								telefon.KisiSil(isim, soyisim);
								telefon.Yazdir();

							}
						}
						else if (secenek == 1)
						{
							Console.WriteLine("Silme işlemi sonlandırıldı.");

						}
						else
						{
							Console.WriteLine("Yanlış sayı girişi");
						}
					}

					break;



				case 3:

					Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");

					Console.WriteLine("İsminizi girin");
					isim = Console.ReadLine();

					Console.WriteLine("Soyisminizi girin");
					soyisim = Console.ReadLine();

					if (telefon.KisiVarmi(isim, soyisim))
					{
						Console.WriteLine("Yeni numarayı girin");
						numara = Convert.ToInt32(Console.ReadLine());
						telefon.NumaraGuncelleme(isim, soyisim, numara);
						telefon.NuamraDogruysaGetir(numara);
					}

					else
					{
						Console.WriteLine("Böyle bir kişi kayıtlı değil");
					}

					break;


				case 4:

					telefon.Yazdir();
					break;


				case 5:

					Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.\n" +
							"**********************************************\n\n" +
							"İsim veya soyisime göre arama yapmak için: (1)\n" +
							"Telefon numarasına göre arama yapmak için: (2)");


					secenek = Convert.ToInt32(Console.ReadLine());

					if (secenek == 1)
					{
						Console.WriteLine("İsminizi girin");
						isim = Console.ReadLine();

						Console.WriteLine("Soyisminizi girin");
						soyisim = Console.ReadLine();


						if (telefon.KisiVarmi(isim, soyisim))
						{
							telefon.IsimSoyIsımDogruysaGetir(isim, soyisim);
						}
						else
						{
							Console.WriteLine("Kişi bulunamadı");
						}

					}
					else if (secenek == 2)
					{
						Console.WriteLine("Numarayı girin");
						numara = Convert.ToInt32(Console.ReadLine().ToString());

						if (telefon.NUmarayaAitKisiVarmi(numara))
						{
							telefon.NuamraDogruysaGetir(numara);
						}
						else
						{
							Console.WriteLine("Kişi bulunamadı");
						}

					}
					else
					{
						Console.WriteLine("Yanlış giriş yaptınız");
					}

					break;

				default:
					Console.WriteLine("Yanlış giriş yaptınız");
					break;
			}
		}

		public class TelefonRehberi
		{
			string isim;
			string soyisim;
			int telefonNumarasi = 0;

			public string Isim { get => isim; set => isim = value; }
			public string Soyisim { get => soyisim; set => soyisim = value; }
			public int TelefonNumarasi { get => telefonNumarasi; set => telefonNumarasi = value; }


			List<TelefonRehberi> TelefonRehberi1 = new List<TelefonRehberi>();

			public void KisiEkle(string isim, string soyisim, int TelefonNumarasi)
			{
				TelefonRehberi1.Add(new TelefonRehberi()
				{
					Isim = isim,
					Soyisim = soyisim,
					TelefonNumarasi = TelefonNumarasi,

				});
			}


			public void KisiSil(string isim, string soyisim)
			{
			
				foreach (var item in TelefonRehberi1)
				{

					if (item.isim == isim && item.soyisim == soyisim)
					{
						Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", isim);
						string YesOrNo = Console.ReadLine();

						if (YesOrNo == "yes")
						{
							Console.WriteLine("{0} {1} kişisi silindi.", isim, soyisim);
							TelefonRehberi1.RemoveAt(TelefonRehberi1.IndexOf(item));
							break;
						}

						else if (YesOrNo == "no")
						{
							Console.WriteLine("Kişiyi silmekten vazgeçtiniz.");
							break;
						}
					}
				}
			}



			public void Yazdir()
			{
				foreach (var item in TelefonRehberi1)
				{
					Console.WriteLine("Telefon Rehberi :");
					Console.WriteLine(TelefonRehberi1.IndexOf(item) + " \n" + item.Isim + " \n" + item.Soyisim + " \n" + item.TelefonNumarasi + "\n-");
				}
			}



			public bool KisiVarmi(string isim, string soyisim)
			{
				foreach (var item in TelefonRehberi1)
				{
					if (item.isim == isim && item.soyisim == soyisim)
					{
						return true;
					}
				}

				return false;
			}


			public bool NUmarayaAitKisiVarmi(int numara)
			{
				foreach (var item in TelefonRehberi1)
				{
					if (item.TelefonNumarasi == numara)
					{
						return true;
					}
				}

				return false;
			}


			public void IsimSoyIsımDogruysaGetir(string isim, string soyisim)
			{
				foreach (var item in TelefonRehberi1)
				{
					if (item.isim == isim && item.soyisim == soyisim)
					{
						Console.WriteLine("Bulunan kişi :");
						Console.WriteLine(TelefonRehberi1.IndexOf(item) + " \n" + item.Isim + " \n" + item.Soyisim + " \n" + item.TelefonNumarasi + "\n-");
						break;
					}

				}
			}


			public void NuamraDogruysaGetir(int numara)
			{
				foreach (var item in TelefonRehberi1)
				{
					if (item.telefonNumarasi == numara)
					{
						Console.WriteLine("Kişi  :");
						Console.WriteLine(TelefonRehberi1.IndexOf(item) + " \n" + item.Isim + " \n" + item.Soyisim + " \n" + item.TelefonNumarasi + "\n-");
						break;
					}
				}
			}


			public void NumaraGuncelleme(string isim, string soyisim, int numara)
			{

				foreach (var item in TelefonRehberi1)
				{
					if (item.isim == isim && item.soyisim == soyisim)
					{
						Console.WriteLine("Numara Güncellendi :");
						item.TelefonNumarasi = numara;
						break;
					}

				}
			}


		}
	}
}
