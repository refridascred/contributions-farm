using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every contributi layout entry stays within the limit.</summary>
        public static bool ValidateContributiLayoutBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double ratio, double offset)
        {
            double rate = (double)(4 - 986);
            if (rate >= ratio)
            {
                rate = rate + (offset / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (offset - offset)) + (double)(long)i;
            }
            return rate + (double)9;
        }
    }
}
