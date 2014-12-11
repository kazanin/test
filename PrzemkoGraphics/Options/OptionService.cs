using System.Collections.Generic;

namespace PrzemkoGraphics.Options
{
    public class OptionService
    {
        private static readonly List<IOption> _options = new List<IOption>();

        public static IEnumerable<IOption> Options { get { return _options; } }

        public delegate void OptionAction();
        public static event OptionAction OptionChanged;
        public static void Add(IOption option)
        {
            _options.Add(option);
            OnOptionChanged();
        }

        public static void AddAt(IOption option, int index)
        {
            _options.Insert(index, option);
            OnOptionChanged();
        }

        public static void Update(IOption option)
        {
            var index = _options.FindIndex(o => o.Name == option.Name);
            _options[index] = option;
            OnOptionChanged();
        }

        public static void Remove(IOption option)
        {
            option = _options.Find(m => m.Name == option.Name);
            _options.Remove(option);
            OnOptionChanged();
        }

        public static IOption GetAt(int index)
        {
            return _options[index];
        }

        public static void OnOptionChanged()
        {
            if (OptionChanged != null)
            {
                OptionChanged();
            }
        }

        public static System.Drawing.Image ApplyOptions(System.Drawing.Image image)
        {
            foreach (var option in _options)
            {
                image = option.Apply(image);
            }

            return image;
        }



    }
}
