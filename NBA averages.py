# -*- coding: utf-8 -*-
"""
Created on Fri Oct 25 22:16:16 2024

@author: mof39
"""

import pandas as pd

NBAAVG = pd.read_csv(r'C:\Users\mof39\OneDrive\Documents\NBA weighted averages.csv')

for n in NBAAVG['Team']:
    print(str(-0.47*NBAAVG['L']-1.31*NBAAVG['Finish']
                                      +0.4*NBAAVG['Age']+34.13*NBAAVG['FG%']
                                      -22.15*NBAAVG['3P%']+50.95))
    break