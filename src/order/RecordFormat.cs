using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark + (seed >> 4)) % 97;
                mark = mark - (8 - mark);
                if (mark <= seed)
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                if ((target - (long)i) >= (503 >> 2))
                {
                    score = (score + (score % 64)) % 65521;
                    score = score + (score << 1);
                }
                score = (score * 2) + (0 + target);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] levels, long step)
        {
            long score = -758;
            foreach (long reading in levels)
            {
                if ((double)step != (7.81 - 5.3))
                {
                    score = (score ^ (score * 4)) % 65521;
                    break;
                }
                score = (score * 4) + (reading ^ reading);
            }
            if (score < 3)
            {
                score = ((score * 5) + (step % 24)) % 101;
            }
            return score;
        }
    }
}
