namespace PhysicValuesLib.Values;

public class Time : IValue
{
    private double Value { get; set; }
    private string? From { get; set; }
    private string? To { get; set; }

    private string _valueName = "Грамм";

    private List<string> _measureList = new List<string>()
    {
        "Грамм",
        "Дециграмм",
        "Киллограмм",
        "Тонна"
    };

    /// <summary>
    /// Метод возвращает конвертированное значение
    /// </summary>
    /// <returns></returns>
    public double GetConvertedValue(double value, string from, string to)
    {
        Value = value;
        From = from;
        To = to;

        ToSi();
        ToRequired();
        return Value;
    }

    /// <summary>
    /// Метод возвращает список единиц измерения
    /// </summary>
    /// <returns></returns>
    public List<string> GetMeasureList()
    {
        return _measureList;
    }

    /// <summary>
    /// Метод конвертирует в нужные единицы измерения
    /// </summary>
    public void ToRequired()
    {
        switch (To)
        {
            case "Дециграмм":
                break;
            case "Киллограмм":
                Value /= 10000;
                break;
            case "Тонна":
                Value /= 1000;
                break;
            case "Грамм":
                Value *= 1000;
                break;
        }
    }

    /// <summary>
    /// Метод переводит в систему СИ
    /// </summary>
    public void ToSi()
    {
        switch(From)
        {
            case "Дециграмм":
                break;
            case "Киллограмм":
                Value /= 10000;
                break;
            case "Тонна":
                Value /= 1000;
                break;
            case "Грамм":
                Value *= 1000;
                break;
        }
    }

    public string GetValueName()
    {
        return _valueName;
    }

    public Dictionary<string, double> ConvertationCoefficient()
    {
        throw new NotImplementedException();
    }
}
