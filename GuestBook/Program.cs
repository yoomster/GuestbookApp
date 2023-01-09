using GuestBook;
using System.Net;


List<string> allGuests = new List<string>();
List<double> totalGuests = new List<double>();

string names;
double peopleInGroup;

do
{
	names = ConsoleMethods.GroupName();
	if (names.ToLower() != "exit")
{
	allGuests.Add(names);
	
	peopleInGroup = ConsoleMethods.GroupSize();
	totalGuests.Add(peopleInGroup);

}
} while (names.ToLower() != "exit");

ConsoleMethods.AllFamilieNames(allGuests);
ConsoleMethods.FamilySizeList(totalGuests);