internal class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
    // Phương thức tìm số lượng số dương liên tiếp nhiều nhất trong mảng
    static int FindMaxConsecutivePositive(int[] arr)
    {
        int maxCount = 0;
        int currentCount = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                currentCount++;

                // Cập nhật số lượng số dương liên tiếp nhiều nhất
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }
            else
            {
                // Reset số lượng số dương liên tiếp khi gặp số không dương
                currentCount = 0;
            }
        }

        return maxCount;
    }

    // Phương thức tính trung bình cộng các phần tử dương trong mảng
    static double CalculateAveragePositive(int[] arr)
    {
        int sumPositive = 0;
        int countPositive = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                sumPositive += arr[i];
                countPositive++;
            }
        }

        // Kiểm tra để tránh chia cho 0 nếu không có phần tử dương nào
        if (countPositive > 0)
        {
            return (double)sumPositive / countPositive;
        }
        else
        {
            return 0; // Hoặc giá trị bất kỳ nếu muốn xử lý riêng trường hợp không có số dương
        }
    }
    // Phương thức kiểm tra mảng có các phần tử âm dương đan xen nhau hay không
    static bool CheckAlternatingSign(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            // Kiểm tra các phần tử liên tiếp có dấu khác nhau
            if ((arr[i] >= 0 && arr[i - 1] >= 0) || (arr[i] < 0 && arr[i - 1] < 0))
            {
                return false;
            }
        }

        return true;
    }
    private static void Main(string[] args)
    {
        int[] a = new int[] {  -4, 5, -72, 100, 3,1, -45, 8, -9, 11 };
        // tim pt nhỏ nhất 
        int min = a[0];
        for(int i = 0; i < a.Length; i++)
        {
            if (a[i] < min)
            {
                min = a[i];
            }
        }
        Console.WriteLine("Phan tu nho nhat:" + min);
        // đảo ngược mảng 
        int start = 0;
        int end = a.Length - 1;

        while(start < end)
        {
            int temp = a[start];
            a[start] = a[end];
            a[end] = temp;
            start++;
            end--;
        }
        Console.WriteLine("Mang sau khi dao nguoc: ");
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]+ " ");
        }
        // sx mảng tăng 
        Array.Sort(a);
        Console.WriteLine("Mảng đã sắp xếp tăng dần:");
        foreach (var item in a)
        {
            Console.WriteLine(item + " ");
        }
        // sx mảng giảm dần 
        Array.Sort(a);
        // Sử dụng phương thức Array.Reverse() để đảo ngược mảng và biến nó thành giảm dần
        Array.Reverse(a);

        // In mảng đã sắp xếp giảm dần ra màn hình
        Console.WriteLine("Mảng đã sắp xếp giảm dần:");
        foreach (var item in a)
        {
            Console.WriteLine(item + " ");
        }
        // Tìm pt là số nguyên tố 

        Console.WriteLine("Các số nguyên tố trong mảng:");
        foreach (var item in a)
        {
            if (IsPrime(item))
            {
                Console.WriteLine(item + " ");
            }
        }
        // in ra số lượng số dương liên tiếp nhiều nhất 

        // Gọi phương thức để tìm số lượng số dương liên tiếp nhiều nhất
        int maxConsecutivePositive = FindMaxConsecutivePositive(a);
        // In kết quả ra màn hình
        Console.WriteLine("Số lượng số dương liên tiếp nhiều nhất là: " + maxConsecutivePositive);

        // Gọi phương thức để tính trung bình cộng các phần tử dương
        double averagePositive = CalculateAveragePositive(a);

        // In kết quả ra màn hình
        Console.WriteLine("Trung bình cộng các phần tử dương là: " + averagePositive);



        // Gọi phương thức để kiểm tra mảng có các phần tử âm dương đan xen nhau hay không
        bool isAlternating = CheckAlternatingSign(a);

        // In kết quả ra màn hình
        if (isAlternating)
        {
            Console.WriteLine("Mảng có các phần tử âm dương đan xen nhau.");
        }
        else
        {
            Console.WriteLine("Mảng không có các phần tử âm dương đan xen nhau.");
        }

    }
}