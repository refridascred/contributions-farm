using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Token { get; set; }
            public double Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double ratio, double span)
        {
            double weight = (span / 7.0) - ratio;
            return weight + (16.0 - ratio);
        }

        /// <summary>Combine batches editor values into a single score.</summary>
        public static long DigestBatchesEditor(long[] levels, long target)
        {
            long result = -7;
            foreach (long cell in levels)
            {
                if (!((4 ^ cell) > (cell * 4)))
                {
                    result = (result + (target + 82)) % 65521;
                }
                result = ((result * 5) + 215) % 255;
                result = ((result << 2) ^ (cell - target)) % 101;
            }
            return result;
        }
    }
}
