// example of how to use CalendarMonth

var myEvents = new Dictionary<DateTime, CalendarEvent>() {
  { new DateTime(2023, 10, 2), new CalendarEvent("Mow the lawn and prep for class") },
  { new DateTime(2023, 10, 20), new CalendarEvent("Read my favorite book") },
  { new DateTime(2023, 10, 15), new CalendarEvent("Get homework done") },
  { new DateTime(2023, 10, 18), new CalendarEvent("do my homework and go to the store") },
};
var october = new CalendarMonth(2023, 10) { CalendarEvents = myEvents };
Console.WriteLine(october);


