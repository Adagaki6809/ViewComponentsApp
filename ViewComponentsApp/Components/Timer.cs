using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ViewComponentsApp.Components
{
    [ViewComponent]
    public class Timer
    {
        public string Invoke(bool includeSeconds, bool format24)
        {
            
            string time = String.Empty;
            DateTime now = DateTime.Now;

            if (format24)   // если 24-часовой формат
                time = now.ToString("HH:mm");
            else           // если 12-часовой формат
                time = now.ToString("hh:mm");

            if (includeSeconds) // если надо добавить секунды
                time = $"{time}:{now.Second}";

            return $"Tекущее время: {time}";
        }
    }
}