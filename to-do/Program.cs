using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_do
{
	class Program
	{
		static void Main(string[] args)
		{
			PrintStartScreen();
		}



		static void PrintStartScreen()
		{
			Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz.");
			Console.WriteLine("**************************************");

			Console.WriteLine("(1) Board Listelemek");
			Console.WriteLine("(2) Board'a Kart Eklemek");
			Console.WriteLine("(3) Board'dan Kart Silmek");
			Console.WriteLine("(4) Kart Taşımak");

			//GELEN DEĞERE GÖRE PROGRAMI YÖNLENDİR
			RouteProcess(int.Parse(Console.ReadLine()));

		}


		static void RouteProcess(int processType)
		{
			switch (processType)
			{
				case 1: ListBoardProcess(); break;
				case 2: AddCardToBoard(); break;
				case 3: DeleteCardToBoard(); break;
				case 4: CarryCard(); break;
				default: Console.WriteLine("Hatalı İşlem."); PrintStartScreen(); break;
			}
		}



		static void ListBoardProcess()
		{
			BoardManager _bm = new BoardManager();
			var boardElements = _bm.ListBoard();


			ListBoardTodoElements(boardElements.Where(x => x.Status == StatusType.TODO).Select(x => new Card()
			{
				Title = x.Card.Title,
				Content = x.Card.Content,
				AssignedMemberId = x.Card.AssignedMemberId,
				Size = x.Card.Size

			}).ToList());
			ListBoardInProgressElements(boardElements.Where(x => x.Status == StatusType.INPROGRESS).Select(x => new Card()
			{
				Title = x.Card.Title,
				Content = x.Card.Content,
				AssignedMemberId = x.Card.AssignedMemberId,
				Size = x.Card.Size

			}).ToList());
			ListBoardDoneElements(boardElements.Where(x => x.Status == StatusType.DONE).Select(x => new Card()
			{
				Title = x.Card.Title,
				Content = x.Card.Content,
				AssignedMemberId = x.Card.AssignedMemberId,
				Size = x.Card.Size

			}).ToList());

			PrintStartScreen();
		}



		private static void ListBoardTodoElements(List<Card> cards)
		{
			MemberManager _mm = new MemberManager();

			Console.WriteLine("TODO Line");
			Console.WriteLine("*****************");


			foreach (var card in cards)
			{
				Console.WriteLine("Başlık : " + card.Title);
				Console.WriteLine("İçerik : " + card.Content);
				Console.WriteLine("Atanan Kişi : " + _mm.FindMember(card.AssignedMemberId).FullName);
				Console.WriteLine("Büyüklük : " + card.Size.ToString());
				Console.WriteLine("--------------------------------------------");
			}
		}



		private static void ListBoardInProgressElements(List<Card> cards)
		{
			MemberManager _mm = new MemberManager();

			Console.WriteLine("IN PROGRESS Line");
			Console.WriteLine("*****************");


			foreach (var card in cards)
			{
				Console.WriteLine("Başlık : " + card.Title);
				Console.WriteLine("İçerik : " + card.Content);
				Console.WriteLine("Atanan Kişi : " + _mm.FindMember(card.AssignedMemberId).FullName);
				Console.WriteLine("Büyüklük : " + card.Size.ToString());
				Console.WriteLine("--------------------------------------------");
			}
		}



		private static void ListBoardDoneElements(List<Card> cards)
		{
			MemberManager _mm = new MemberManager();

			Console.WriteLine("DONE Line");
			Console.WriteLine("*****************");


			foreach (var card in cards)
			{
				Console.WriteLine("Başlık : " + card.Title);
				Console.WriteLine("İçerik : " + card.Content);
				Console.WriteLine("Atanan Kişi : " + _mm.FindMember(card.AssignedMemberId).FullName);
				Console.WriteLine("Büyüklük : " + card.Size.ToString());
				Console.WriteLine("--------------------------------------------");
			}
		}



		static void AddCardToBoard()
		{
			Card card = new Card();
			MemberManager _mm = new MemberManager();
			BoardManager _bm = new BoardManager();

			Console.WriteLine("Başlık Giriniz");
			card.Title = Console.ReadLine();

			Console.WriteLine("İçerik Giriniz");
			card.Content = Console.ReadLine();

			Console.WriteLine("Büyüklük Giriniz => XS(1), S(2), M(3), L(4), XL(5)");
			card.Size = (SizeType)int.Parse(Console.ReadLine());

			Console.WriteLine("Kişi Numarası Giriniz");
			int memberId = int.Parse(Console.ReadLine());

			if (_mm.FindMember(memberId) == null)
			{
				Console.WriteLine("Girilen Numarada Kullanıcı Bulunamadı.");
				PrintStartScreen();
			}

			card.AssignedMemberId = memberId;
			var result = _bm.AddCardToBoard(card);

			if (result)
				Console.WriteLine("Kart Başarıyla Board'a Eklendi.");
			else
				Console.WriteLine("Kart Board'a Eklenemedi.");

			PrintStartScreen();


		}



		static void DeleteCardToBoard()
		{
			Console.WriteLine("Öncelikle Silmek İstediğiniz Kartı Seçmeniz Gerekiyor.");
			Console.WriteLine("Lütfen Kart Başlığını Yazınız.");

			BoardManager _bm = new BoardManager();
			var finfBoardElement = _bm.FindBoardElementByCard(Console.ReadLine());

			if (finfBoardElement == null)
			{
				Console.WriteLine("Aradığınız Kart Bulunamadı.");
				Console.WriteLine("Ana Menüye Dön (1)");
				Console.WriteLine("Tekrar Dene (2)");

				int processType = int.Parse(Console.ReadLine());

				if (processType == 1)
					PrintStartScreen();
				else if (processType == 2)
					DeleteCardToBoard();
			}

			var result = _bm.RemoveBoardElement(finfBoardElement);

			if (result)
				Console.WriteLine("Kart Başarıyla Board'dan Silindi.");
			else
				Console.WriteLine("Kart Board'dan Silinemedi.");

			PrintStartScreen();
		}



		static void CarryCard()
		{
			Console.WriteLine("Öncelikle Taşımak İstediğiniz Kartı Seçmeniz Gerekiyor.");
			Console.WriteLine("Lütfen Kart Başlığını Yazınız.");

			BoardManager _bm = new BoardManager();
			var finfBoardElement = _bm.FindBoardElementByCard(Console.ReadLine());

			if (finfBoardElement == null)
			{
				Console.WriteLine("Aradığınız Kart Bulunamadı.");
				Console.WriteLine("Ana Menüye Dön (1)");
				Console.WriteLine("Tekrar Dene (2)");

				int processType = int.Parse(Console.ReadLine());

				if (processType == 1)
					PrintStartScreen();
				else if (processType == 2)
					CarryCard();
			}

			PrintBoardElementDetails(finfBoardElement);
			PrintChangeLineText();
			int lineValue = int.Parse(Console.ReadLine());

			if (lineValue < 1 || lineValue > 3)
			{
				Console.WriteLine("Hatalı Seçim Yaptınız.");
				PrintStartScreen();
			}

			finfBoardElement.Status = (StatusType)lineValue;
			var result = _bm.CarryCard(finfBoardElement);

			if (result)
				Console.WriteLine("Kart Başarıyla Taşındı.");
			else
				Console.WriteLine("Kart Taşınamadı.");

			PrintStartScreen();



		}


		static void PrintBoardElementDetails(BoardElement boardElement)
		{
			MemberManager _mm = new MemberManager();

			Console.WriteLine("Bulunan Kart Bilgileri");
			Console.WriteLine("************************************");
			Console.WriteLine("Başlık : " + boardElement.Card.Title);
			Console.WriteLine("İçerik : " + boardElement.Card.Content);
			Console.WriteLine("Atanan Kişi : " + _mm.FindMember(boardElement.Card.AssignedMemberId).FullName);
			Console.WriteLine("Büyüklük : " + boardElement.Card.Size.ToString());
			Console.WriteLine("Line : " + (boardElement.Status.ToString()));
		}



		private static void PrintChangeLineText()
		{
			Console.WriteLine("Lütfen Taşımak İstediğiniz Line'ı Seçiniz.");
			Console.WriteLine("(1) TODO");
			Console.WriteLine("(2) IN PROGRESS");
			Console.WriteLine("(3) DONE");
		}
	}



	public class Board
	{
		public List<BoardElement> BoardElements { get; set; }

	}

	public static class BoardDataSource
	{
		public static Board Board;


		static BoardDataSource()
		{
			Board = InitializeBoard();
		}

		static Board InitializeBoard()
		{
			return new Board()
			{
				BoardElements = new List<BoardElement>()
		{
		    new BoardElement()
		    {
			Card = new Card("Başlık 1","İçerik 1", 1, SizeType.L),
			Status = StatusType.DONE
		    },

		    new BoardElement()
		    {
			Card = new Card("Başlık 2","İçerik 2", 2, SizeType.XL),
			Status = StatusType.INPROGRESS
		    },

		    new BoardElement()
		    {
			Card = new Card("Başlık 3","İçerik 3", 3, SizeType.XS),
			Status = StatusType.TODO
		    }
		}
			};
		}
	}

	public class BoardElement
	{
		public Card Card { get; set; }
		public StatusType Status { get; set; }


		public BoardElement(Card card, StatusType status)
		{
			this.Card = card;
			this.Status = status;
		}


		public BoardElement()
		{

		}
	}

	public class BoardManager
	{

		public List<BoardElement> ListBoard()
		{
			return BoardDataSource.Board.BoardElements.ToList();
		}


		public bool AddCardToBoard(Card card)
		{
			try
			{
				/*YENİ EKLENEN KART tTODO STATÜSÜNDE EKLENİYOR */
				BoardDataSource.Board.BoardElements.Add(new BoardElement(card, StatusType.TODO));
				return true;
			}
			catch (Exception e)
			{
				return false;
			}
		}



		public BoardElement FindBoardElementByCard(string cardTitle)
		{
			return BoardDataSource.Board.BoardElements.FirstOrDefault(x => x.Card.Title.ToLower() == cardTitle.ToLower());
		}




		public bool RemoveBoardElement(BoardElement boardElement)
		{
			try
			{
				BoardDataSource.Board.BoardElements.Remove(boardElement);
				return true;
			}
			catch (Exception e)
			{
				return false;
			}
		}



		public bool CarryCard(BoardElement boardElement)
		{
			try
			{
				foreach (var element in BoardDataSource.Board.BoardElements)
				{
					//REFERANSLAR EŞİT İSE, GÜNCELLE
					if (element == boardElement)
					{
						element.Status = boardElement.Status;
						break;
					}
				}

				return true;
			}
			catch (Exception e)
			{
				return false;
			}
		}
	}

	public class Card
	{
		public string Title { get; set; }
		public string Content { get; set; }
		public int AssignedMemberId { get; set; }
		public SizeType Size { get; set; }


		public Card(string title, string content, int assignedMemberId, SizeType size)
		{
			this.Title = title;
			this.Content = content;
			this.AssignedMemberId = assignedMemberId;
			this.Size = size;
		}


		public Card()
		{

		}
	}

	public class Member
	{
		public int Id { get; set; }
		public string FullName { get; set; }


		public Member(int id, string fullName)
		{
			this.Id = id;
			this.FullName = fullName;
		}
	}

	public static class MemberDataSource
	{
		public static List<Member> Members;


		static MemberDataSource()
		{
			Members = InitializeMembers();
		}



		static List<Member> InitializeMembers()
		{
			return new List<Member>()
	    {
		new Member(1,"Hilal Öztürk"),
		new Member(2,"Fatma Yılmaz")

	    };
		}
	}

	public class MemberManager
	{

		public Member FindMember(int memberId)
		{
			return MemberDataSource.Members.FirstOrDefault(x => x.Id == memberId);
		}
	}


	public enum SizeType
	{
		XS = 1,
		S,
		M,
		L,
		XL
	}

	public enum StatusType
	{
		TODO = 1,
		INPROGRESS,
		DONE
	}


}

