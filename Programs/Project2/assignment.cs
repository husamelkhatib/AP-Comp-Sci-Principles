public class Assignment {
  public string Title {get; set;}
  public string Duedate { get; set;}
  public string Subject {get; set;}
  public string Description {get; set;}
  public bool IsCompleted {get; set;}

  public Assignment(string title, string dueDate, string subject, string description) {
    Title = title;
    Duedate = dueDate;
    Subject = subject;
    Description = description;
    IsCompleted = false;
  }

  public override string ToString() {
    return (Title + " - " + Subject + " - Due: " + Duedate + " - Completed " + IsCompleted);
  }
}
