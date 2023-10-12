using ConsoleApp1;

#region Menu
var selectedMenuItem = Menu.GetMenu();
#endregion

#region Günler
if (selectedMenuItem.KeyChar == '1')
{
    Day.GetDay();
}
#endregion Günler

#region Aylar
if (selectedMenuItem.KeyChar == '2')
{
    Month.GetMonth();
}
#endregion Günler

#region Mevsimler
if (selectedMenuItem.KeyChar == '3')
{
    Season.GetSeason();
}
#endregion Günler






