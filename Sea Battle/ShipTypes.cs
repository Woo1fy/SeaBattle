using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_Battle
{
    abstract class ShipTypes
    {
        public string ShipName { get; }
        public int CountShip { get; }
        public ShipTypes(string name = "NoName", int count = default)
        { ShipName = name; CountShip = count; }

        // Единственный виртуальный метод.
        // Вынудить все дочерние классы определять способ своей визуализации.
        public abstract void Draw();

    }

    class FiveDeckShip : ShipTypes
    {
        public FiveDeckShip() { }
        public FiveDeckShip(string name, int count) : base(name, count) { }
        public override void Draw()
        {
            Console.WriteLine(ShipName + $" {CountShip} единиц");
        }
    }

    class FourDeckShip : ShipTypes
    {
        public FourDeckShip() { }
        public FourDeckShip(string name, int count) : base(name, count) { }
        public override void Draw()
        {
            Console.WriteLine(ShipName + $" {CountShip} единиц");
        }
    }

    class ThreeDeckShip : ShipTypes
    {
        public ThreeDeckShip() { }
        public ThreeDeckShip(string name, int count) : base(name, count) { }
        public override void Draw()
        {
            Console.WriteLine(ShipName + $" {CountShip} единиц");
        }
    }

    class TwoDeckShip : ShipTypes
    {
        public TwoDeckShip() { }
        public TwoDeckShip(string name, int count) : base(name, count) { }
        public override void Draw()
        {
            Console.WriteLine(ShipName + $" {CountShip} единиц");
        }
    }

    class OneDeckShip : ShipTypes
    {
        public OneDeckShip() { }
        public OneDeckShip(string name, int count) : base(name, count) { }
        public override void Draw()
        {
            Console.WriteLine(ShipName + $" {CountShip} единиц");
        }
    }
}
