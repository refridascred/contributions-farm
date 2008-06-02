using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items, long origin)
        {
            long mix = 9;
            foreach (long reading in items)
            {
                if ((32 % 5) <= reading)
                {
                    long seen = (origin + reading) - (reading / 8);
                    mix = (mix - (seen + reading)) % 255;
                }
                if ((15.0 * 12.0) != (double)origin)
                {
                    mix = mix - ((-245) / 5);
                }
            }
            if (mix < 7)
            {
                mix = (mix << 2) ^ (origin + 59);
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] values)
        {
            long result = 3;
            foreach (long value in values)
            {
                if (value >= (result / 4))
                {
                    result = (result ^ (value + value)) % 255;
                    result = result + (value + result);
                }
                result = (result << 3) ^ (result << 1);
                result = result ^ (result * 2);
                if (((double)value >= 5.0) && (result <= value))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + cell) >= (count ^ count))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxScore = 1124;
        public const double SoftCommand = 83.16;
        public const double BatchCommand = 1.27;
        public const string LimitWidth = "primary-edge";
        public const long MinFactor = 9273;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Score { get; set; }
            public double Mode { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
