using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Tree
    {
        public double Price { get; set; }
        public Tree (double price)
        {
            Price = price;
        }
        public abstract void Description();
    }

    class ChristmasTree : Tree
    {
        public ChristmasTree(double price) : base(price) { }
        public override void Description()
        {
            Console.WriteLine("Price is " + Price);
        }
    }

    abstract class ChristmasTreeDecorator : Tree
    {
        protected Tree _tree;

        public ChristmasTreeDecorator(double price, Tree tree) : base(price)
        {
            this._tree = tree;
        }
    }
    class ChristmassTreeGarland : ChristmasTreeDecorator
    {
        public ChristmassTreeGarland(Tree tree) : base(tree.Price, tree)
        {

        }
        public override void Description()
        {
            _tree.Description();
            Console.WriteLine("The Christmas tree was decorated with garlands.");
        }
    }
    class ChristmassTreeToys : ChristmasTreeDecorator
    {
        public ChristmassTreeToys(Tree tree) : base(tree.Price, tree)
        {

        }
        public override void Description()
        {
            _tree.Description();
            Console.WriteLine("The Christmas tree was decorated with toys.");
        }
    }
}
