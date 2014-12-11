using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzemkoGraphics.Gallery
{
    public class ItemService
    {
        public static readonly List<Item> _items = new List<Item>();
        public static IEnumerable<Item> Items { get { return _items; } }

        private static Item _current;
        
        public delegate void ItemChange();
        public static event ItemChange CurrentItemChanged;
        public static event ItemChange ItemRemoved;

        public static int Count
        {
            get { return _items.Count(); }
        }
        public static void Add(Item item)
        {
            _items.Add(item);
        }

        public static void Remove(Item item)
        {
            _items.Remove(item);
            OnItemRemoved();
        }

        public static void RemoveAll()
        {
            for (int i = 0; i < Items.Count(); i++)
            {
                _items[i].Dispose();
            }
            
            _items.Clear();
            OnItemRemoved();
        }


        public static Item Current
        {
            get
            {
                if (_current == null)
                    throw new Exception("No image selected");

                return _current;
            }
            set
            {
                _current = value;
                _current._pictureBox.BackColor = Color.Aqua;

                foreach (var item in ItemService.Items)
                {
                    if (item != _current)
                        item._pictureBox.BackColor = Color.Black;
                }

                OnCurrentChanged();
            }
        }

        public static Item GetFirst
        {
            get
            {
                if (_items.Count == 0)
                    throw new Exception("No image to fetch");

                return _items[0];
            }
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
