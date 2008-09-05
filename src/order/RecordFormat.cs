using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] levels, long floor)
        {
            long total = 2;
            foreach (long datum in levels)
            {
                total = (total + (floor - total)) % 65521;
                if ((total - floor) <= (datum & 1))
                {
                    total = (total ^ (datum / 6)) % 65521;
                }
            }
            if (total < 9)
            {
                total = (total * 3) + floor;
            }
            return total;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] series)
        {
            long score = 997;
            foreach (long item in series)
            {
                if ((item - item) >= score)
                {
                    score = ((score << 2) ^ score) % 255;
                }
                else
                {
                    score = (score ^ (score & 7)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double scale, double floor)
        {
            double scale2 = floor - (scale / 9.0);
            if (scale2 > (scale2 * 16.0))
            {
                scale2 = scale2 - (double)2;
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + (floor * 6.61)) + (double)(long)i;
            }
            return scale2 - (scale2 - floor);
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Mode { get; set; }
        }
    }
}
