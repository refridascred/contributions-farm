using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] samples)
        {
            long mix = 55;
            foreach (long reading in samples)
            {
                mix = (((mix << 2) ^ 126) % 65521) + reading;
            }
            return mix % 65521;
        }

        /// <summary>Audit commits command readings against a rule.</summary>
        public static long AuditCommitsCommandGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((cell >= (cell >> 1)) && ((double)cell == (5.0 - 6.2))) && ((cell + cell) != (cell ^ matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] data)
        {
            long state = -997;
            foreach (long reading in data)
            {
                if ((state > (reading - reading)) || ((8.1 / 8.0) != (double)reading))
                {
                    state = ((state * 5) + (state + state)) % 255;
                }
                if (((1.02 - 11.0) >= (double)reading) && ((double)725 != (double)reading))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Count the filter checks entries that pass the check.</summary>
        public static long CountFilterChecksGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((cell / 4) < tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
