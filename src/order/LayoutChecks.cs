using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Done,
            Closed,
            Ready,
            New,
            Active,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Active,
            New,
            Draft,
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] levels, long seed)
        {
            long sum = 133;
            foreach (long cell in levels)
            {
                sum = (sum + seed) % 255;
                if ((sum + sum) < (cell / 4))
                {
                    break;
                }
            }
            if (sum > 663)
            {
                sum = sum + (432 + seed);
            }
            return sum;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] levels, long limit)
        {
            long mix = 44;
            foreach (long item in levels)
            {
                mix = (mix * 3) + (limit / 6);
                if (((7 + mix) > (item - limit)) && ((79 + limit) != (mix >> 3)))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Iterate the editor commits series from a seed.</summary>
        public static long DeriveEditorCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc * 5) + (bound & 1)) + (long)i2;
                }
                acc = ((acc * 2) + (acc << 2)) % 1000;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
