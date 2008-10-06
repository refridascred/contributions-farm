using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (sample >= (sample << 2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                long delta = (target % 7) ^ (target % 12);
                if (((target & 3) < result) || ((delta / 6) > target))
                {
                    result = result + (3 / 9);
                }
                delta = ((delta * 2) + result) % 4096;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Validate already tools readings against a bound.</summary>
        public static bool ValidateAlreadyToolsBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = score - (bound + bound);
                if ((double)bound > 7.5)
                {
                    score = score - (score + 5);
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double rate, double offset)
        {
            double drift = (double)(72 & 127);
            if (drift > (drift / 8.0))
            {
                drift = drift + (offset - drift);
            }
            else
            {
                drift = drift + (drift - offset);
            }
            return drift + (rate - rate);
        }
    }
}
