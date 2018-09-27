# dpm.mini.pw.edu.pl - Automatyczna rejestracja

Aplikacja służąca do automatycznej rejestracji na zajęcia dni popularyzacji matematyki.

Aby korzystać z aplikacji należy podać login i hasło do konta na https://dpm.mini.pw.edu.pl/.  
**Dane nie są przechowywane na dysku lub w internecie.**  
Po restarcie należy się ponownie zalogować.

![Preview GIF](https://i.imgur.com/QXhU20G.gif)

[Download / Pobieranie](https://github.com/Zaczero/dpm.mini.pw.edu.pl-Automatyczna-rejestracja/releases)

**Uwaga!**  
Jest to wczesna wersja BETA. Możesz spodziewać się małych błędów. Nie polegaj na tej aplikacji w 100% i ręcznie zweryfikuj czy rejestracja się powiodła.

## Jak korzystać?

1. Uruchom aplikację
2. Zaloguj się danymi z https://dpm.mini.pw.edu.pl/
3. Wprowadź numer zajęć, ilość miejsc, godzinę oraz minutę rejestracji
4. Kliknij przyicks "Dodaj"
5. Teraz tylko chwilkę poczekaj (na godzinę którą podałeś w punkcie 3.)

## Skąd wziąść numer zajęć?

1. Otwórz stronę z zajęciami
2. Przykład: https://dpm.mini.pw.edu.pl/node/690
3. Numer zajęć znajduje się tuż na końcu (3 cyfrowa liczba)
4. W tym przypadku jest to 690

## Po co?

Aby dostać się na część zajęć należy być idealnie z godziną otwarcia zapisów, ponieważ są one tak rozchwytywane. Nie wspominając już, że serwer nie zawsze wytrzymuje taki napór i przez kilka minut próbujemy zapisać się bez sukcesu. Aplikacja ma na celu ułatwienie tego procesu dzięki uproszczonemu systemowi połączenia (szybsze ładowanie strony) oraz automatycznej rejestracji bazującej na podanej godzinie i minucie.

Aplikacja zawiera możliwość wyboru ilości miejsc.

## Wymagania:

* .NET Framework 4.5.2 lub nowszy

## TODO:

* Opcjonalne zapamiętywanie loginu i hasła