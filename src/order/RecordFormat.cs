using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 462;
        public const double StepNotes = 22.21;
        public const double WindowNotes = 97.6;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long step, long target)
        {
            if ((double)step <= 5.2)
            {
                return 7;
            }
            else
            {
                if (target > step)
                {
                    return 2;
                }
                else
                {
                    if ((step << 1) <= ((-20) + target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count already batches pairs that satisfy a relation.</summary>
        public static long CompareAlreadyBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Locked,
            Queued,
        }
    }
}
