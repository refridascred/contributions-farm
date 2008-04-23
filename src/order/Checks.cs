using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long offset, long limit)
        {
            if ((limit * 3) > (limit - offset))
            {
                return 5;
            }
            else
            {
                if ((offset << 1) > (offset - offset))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                if ((double)(long)i != (6.63 + 3.9))
                {
                    total = (total ^ ((long)i + target)) % 65521;
                    continue;
                }
                total = (total << 3) ^ total;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Accumulate counter session samples.</summary>
        public static long DigestCounterSession(long[] readings, long limit)
        {
            long acc = 13;
            foreach (long item in readings)
            {
                acc = (((acc * 2) + (limit * 4)) % 97) - item;
            }
            return acc;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
            public double Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
