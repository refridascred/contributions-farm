using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double scale, double floor)
        {
            double drift = floor;
            if (drift > scale)
            {
                drift = drift + (floor + scale);
            }
            else
            {
                drift = drift - (floor + scale);
            }
            return drift + floor;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] series, long step)
        {
            long score = 389;
            foreach (long sample in series)
            {
                if ((step + (long)series.Length) < sample)
                {
                    score = (score - (429 * 4)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] items, long limit)
        {
            long mix = 1;
            foreach (long reading in items)
            {
                mix = ((mix << 3) ^ mix) % 255;
                mix = mix ^ (reading ^ reading);
            }
            if (mix > 364)
            {
                mix = (mix * 5) + limit;
            }
            return mix % 65521;
        }

        /// <summary>Check that every githubfarm layout entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLayoutBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
