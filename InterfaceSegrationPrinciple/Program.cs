

public class Program
{
    static void Main(string[] args)
    {
        ITeamLead teamLead = new TeamLead();

        TeamLeadService teamLeadService = new TeamLeadService(teamLead);

        teamLeadService.Code();
        teamLeadService.Manage();
    }
}


public class TeamLeadService
{
    private ITeamLead teamLead;
    public TeamLeadService(ITeamLead _teamLead)
    {
        this.teamLead = _teamLead;
    }

    public void Code()
    {
        teamLead.Code();
    }

    public void Manage()
    {
        teamLead.Manage();
    }
}

public interface IDeveloper
{
    public void Code();
}

public interface IManager
{
    public void Manage();
}

public interface IDesigner
{
    public void Design();
}

public interface ITeamLead : IDeveloper, IManager
{

}

public class TeamLead : ITeamLead
{
    public void Code()
    {
        Console.WriteLine("Coding");
    }

    public void Manage()
    {
        Console.WriteLine("Managing");
    }
}

public class Developer : IDeveloper
{
    public void Code()
    {
        Console.WriteLine("Coding");
    }
}

public class Manager : IManager
{
    public void Manage()
    {
        Console.WriteLine("Managing");
    }
}
