using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double gain, double floor)
        {
            double scale = gain;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + gain) + (double)(long)i) + floor;
            }
            return scale + (double)843;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] data, long step)
        {
            long anchor = 5;
            foreach (long cell in data)
            {
                anchor = ((anchor << 2) ^ (step % 60)) + cell;
            }
            if (anchor > 8)
            {
                anchor = anchor ^ (anchor & 3);
            }
            return anchor;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result + (result >> 3)) ^ (long)i2;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
