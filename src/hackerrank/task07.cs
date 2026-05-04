/#include <bits/stdc++.h >

використання простору імен std;

рядок ltrim ( const рядок & ) ;
рядок rtrim ( const рядок & ) ;
вектор<рядок> split ( const рядок & ) ;

/*
 * Виконайте функцію «breakingRecords» нижче.
 *
 * Очікується, що функція поверне цілочисельне число типу INTEGER_ARRAY.
 * Функція приймає значення INTEGER_ARRAY як параметр.
 */

vector <int> breakingRecords ( vector <int> результати ) {
    int max_record = результати [ 0 ] ;
    int min_record = результати [ 0 ] ;
    int count_max = 0 ;
    int count_min = 0 ;

    для ( size_t i = 1 ; i < scores.size ( ) ; i++ ) {
        якщо ( оцінки [ i ] > max_record ) {
            max_record = результати [ i ] ;
            count_max++;
        } інакше якщо ( оцінки [ i ] < хв_запис ) {
            min_record = бали [ i ] ;
            кількість_хв++;
        }
    }

    повернути { максимальна_кількість, мінімальна_кількість } ;
}

головне ціле ( )
{
    ofstream fout ( getenv ( "OUTPUT_PATH" ) ) ;

    рядок n_temp;
    отримати_лінію ( cin, n_temp ) ;

    int n = stoi ( ltrim ( rtrim ( n_temp ) ) ) ;

    рядок scores_temp_temp;
    отримати_лінію ( cin, scores_temp_temp ) ;

    вектор<рядок> scores_temp = split ( rtrim ( scores_temp_temp ) ) ;

    вектор <int> оцінки ( n ) ;

    для ( int i = 0 ; i < n ; i++ ) {
        int scores_item = stoi ( scores_temp [ i ] ) ;

        бали [ i ] = бали_елемент;
    }

    вектор<int> результат = breakingRecords ( результати ) ;

    для ( size_t i = 0 ; i < result.size ( ) ; i++ ) {
        fout << результат [ i ] ;

        якщо ( i != результат.розмір ( ) - 1 ) {
            fout << " " ;
        }
    }

    fout << "\n" ;

    fout.close ( ) ;

    повернути 0 ;
}

рядок ltrim ( const рядок &str ) {
    рядок s ( str ) ;

    s.erase (
        s.begin ( ) ,
        find_if ( s.begin ( ) , s.end ( ) , not1 ( ptr_fun< int , int > ( isspace ) ) )
    ) ;

    повернення ;
}

рядок rtrim ( const рядок &str ) {
    рядок s ( str ) ;

    s.erase (
        find_if ( s.rbegin ( ) , s.rend ( ) , not1 ( ptr_fun< int , int > ( isspace ) ) ) . base ( ) ,
        кінець ( )
    ) ;

    повернення ;
}

вектор<рядок> split ( const рядок &str ) {
    vector<рядок> токени;

    string::size_type початок = 0 ;
    рядок::тип_розміру кінець = 0 ;

    поки ( ( кінець = str.find ( " " , початок ) ) != string::npos ) {
        tokens.push_back ( str.substr ( початок, кінець - початок ) ) ;

        початок = кінець + 1 ;
    }

    токени.push_back ( str.substr ( початок ) ) ;

    повернення токенів;
}
