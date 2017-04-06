using System;

namespace Common.Utilities
{
    /// <summary>Entry support helpers.</summary>
    public static class EntrySupport
    {
        /// <summary>Express a report context count as a percentage.</summary>
        public static double ReportContextPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Wrap a digest index into a fixed-size ring.</summary>
        public static int WrapDigestIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Wrap a cache catalog index into a fixed-size ring.</summary>
        public static int WrapCacheCatalogIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Average a list of payload samples.</summary>
        public static double AveragePayload(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double total = 0.0;
            foreach (double v in values)
            {
                total += v;
            }
            return total / values.Length;
        }

        /// <summary>Sum the decimal digits of a queue id.</summary>
        public static int QueueDigitSum(long n)
        {
            n = n < 0 ? -n : n;
            int total = 0;
            while (n > 0)
            {
                total += (int)(n % 10);
                n /= 10;
            }
            return total;
        }

        /// <summary>Convert a order temperature from celsius to fahrenheit.</summary>
        public static double OrderCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
