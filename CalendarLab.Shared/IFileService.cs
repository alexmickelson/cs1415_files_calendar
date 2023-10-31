public interface IFileService
{
  // loads all the events from their files and returns them as a dictionary
  public Dictionary<DateTime, CalendarEvent> LoadCalendarEvents();

  // saves a single event
  public void SaveCalendarEvent(DateTime dayToSave, CalendarEvent eventToSave);

  // deletes the file storing an event
  public void DeleteCalendarEvent(DateTime dayToDelete);
}