
using System.Text;

public class CalendarMonth
{
  public readonly static int DayWidth = 11;
  public readonly static int DayHeight = 5;
  public required Dictionary<DateTime, CalendarEvent> CalendarEvents { get; init; }
  public List<CalendarWeek> Weeks { get; }
  public CalendarMonth(int year, int month)
  {
    Weeks = StaticCalendarUtils.GetWeeksInMonth(year, month);
  }

  public override string ToString()
  {
    var builder = new StringBuilder(Weeks[1].Days[0].Value.ToString("MMMM") + Environment.NewLine);

    builder.Append(new string('-', ((DayWidth + 3) * 7) + 1));

    foreach (var week in Weeks)
    {
      builder.Append(week.GetFormattedString(CalendarEvents));
    }

    return builder.ToString();
  }
}