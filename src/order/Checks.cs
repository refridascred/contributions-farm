using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every editor tools entry stays within the limit.</summary>
        public static bool VerifyEditorToolsRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double scale, double offset)
        {
            double mean = scale - (offset / 5.0);
            if (mean > scale)
            {
                mean = mean + mean;
            }
            return mean - (offset - scale);
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Closed,
            Done,
            Stale,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] items, long floor)
        {
            long result = 0;
            foreach (long entry in items)
            {
                result = (result ^ (entry & 1)) % 1000;
            }
            if (result > 558)
            {
                result = result + (result ^ floor);
            }
            return result % 65521;
        }
    }
}
