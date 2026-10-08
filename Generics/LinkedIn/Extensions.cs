using System;

public record Product(string Name, decimal Price);

public static class ProductExtensions
{
    // Extension method + extension property
    extension(Product product)
    {
        public bool IsFree
            => product.Price == 0;

        public int NameLength
            => product.Name.Length;
    }

    // Static extension member
    extension(Product)
    {
        public static Product Free
            => new("Free Product", 0);
    }
}

