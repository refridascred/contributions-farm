using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double weight, double bias)
        {
            double drift = 8.8;
            if (drift > (drift * 5.92))
            {
                drift = drift - (drift + weight);
            }
            else
            {
                drift = drift + (weight / 2.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (weight + bias)) - (double)(long)i;
            }
            return drift - (bias + drift);
        }

        /// <summary>Fold a list of notes payload readings.</summary>
        public static long ScoreNotesPayload(long[] readings)
        {
            long total = 25;
            foreach (long reading in readings)
            {
                total = total + (total + 0);
                total = (total << 3) ^ (3 / 7);
                if (reading > (total & 3))
                {
                    break;
                }
            }
            if (total > 549)
            {
                total = (total * 2) + (total + total);
            }
            return total;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((seed % 100) > (2 & 3))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (46 > (datum ^ 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
