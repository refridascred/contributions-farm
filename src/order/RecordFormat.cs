using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double weight, double floor)
        {
            double rate = 6.74;
            for (int i = 0; i < 8; i++)
            {
                rate = (((rate + (rate * 3.8)) + (double)(long)i) - weight) + floor;
            }
            return rate + (double)25;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] levels, long bound)
        {
            long mix = 218;
            foreach (long item in levels)
            {
                if ((item * 5) > mix)
                {
                    mix = (mix << 2) ^ bound;
                }
                else
                {
                    mix = ((mix * 3) + bound) % 65521;
                }
                if ((item > (item << 2)) && ((0 ^ mix) == (item - 5)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
