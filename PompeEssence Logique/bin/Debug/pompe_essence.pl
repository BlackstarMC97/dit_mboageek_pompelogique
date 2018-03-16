% S = !A(M+P) + MP

% Prédicat ET
et(0,0,0).
et(0,1,0).
et(1,0,0).
et(1,1,1).

% Prédicat OU
ou(0,0,0).
ou(0,1,1).
ou(1,0,1).
ou(1,1,1).

% Prédicat NON
non(0,1).
non(1,0).

etat_pompe(A,M,P,R):-non(A,H),ou(M,P,I),et(H,I,J),et(M,P,K),ou(J,K,R).



