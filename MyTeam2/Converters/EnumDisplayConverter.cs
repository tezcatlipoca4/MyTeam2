namespace MyTeam2.Converters
{
    using MyTeam2.Enums;
    using System.Globalization;

    public class EnumDisplayConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is LinkOpenOption option &&
                LinkOpenOptionDisplay.Names.TryGetValue(option, out var name))
            {
                return name;
            }

            return value?.ToString() ?? string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Not needed for Picker binding with SelectedItem
            throw new NotImplementedException();
        }
    }
}
