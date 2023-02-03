namespace Fool.Web;


public class Player 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<string> Hand { get; set; } = null!;

}


public class SharedGameState
{
    // ������ 
    public string[] Deck { get; set; } = null!;
    
    // ��������� ����� �� �����
    public string CardOnTheTable { get; set; }


    public List<Player> Players { get; set; }

    public int CurrentMovePlayerId { get; set; }
}
