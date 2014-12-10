using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzemkoGraphics.Gallery
{
    public static class ItemService
    {
        public static readonly List<Item> Items = new List<Item>();
        private static Item _current;
   //     public static IEnumerable<Item> Items { get { return _items; } }

        public delegate void ItemChange();
        public static event ItemChange CurrentItemChanged;
        public static event ItemChange ItemRemoved;

        public static void Add(Item item)
        {
            Items.Add(item);
        }

        public static void Remove(Item item)
        {
            Items.Remove(item);
            OnItemRemoved();
        }

        public static void SetCurrent(Item item)
        {
            _current = item;
            _current._pictureBox.BackColor = Color.Aqua;
            foreach (var item2 in ItemService.Items)
            {
                if (item2 != _current)
                    item2._pictureBox.BackColor = Color.Black;
            }
            OnCurrentChanged();
        }

        public static Item GetCurrent()
        {
            if (_current == null)
                throw new Exception("Nie ma zaznaczonego obrazka");

            return _current;
        }

        public static void OnCurrentChanged()
        {
            if (CurrentItemChanged != null)
            {
                CurrentItemChanged();
            }
        }

        public static void OnItemRemoved()
        {
            if (ItemRemoved != null)
            {
                ItemRemoved();
            }
        }
        
    }
}
