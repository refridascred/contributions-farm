using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] levels, long seed)
        {
            long mix = 740;
            foreach (long value in levels)
            {
                mix = ((mix << 2) ^ seed) % 65521;
                mix = mix ^ 95;
                if (!(seed <= (value & 127)))
                {
                    mix = (mix << 2) ^ (mix ^ value);
                }
                else
                {
                    mix = (mix ^ (8 ^ seed)) % 255;
                }
                if (!((mix * 2) < value))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long step, long origin)
        {
            if (!((origin + 4) > (step << 1)))
            {
                return 3;
            }
            else
            {
                if ((double)step < 3.5)
                {
                    return 4;
                }
                else
                {
                    if (!((double)origin < (3.64 * 0.5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up entry batches samples.</summary>
        public static long OverlapEntryBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
