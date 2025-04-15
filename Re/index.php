<?php
$conn = new mysqli("localhost","root","","REDing");
/* inserimento admin con password hashata
$usernames = "admin";
$password = hash("sha256","admin");
$sql = "insert into credenziali(username, pwd) values('$usernames', '$password')";
$conn->query($sql);
*/
if($_SERVER['REQUEST_METHOD'] == 'POST'){
    $username = $_POST["name"];
    $pwd = $_POST["pwd"];
    $sql = "select * from credenziali where username = ?";
    $stmt = $conn->prepare($sql);
    $stmt->bind_param("i", $username);
    $stmt->execute();
    $result = $stmt->get_result();
    if($result->num_rows > 0){
        $user = $result->fetch_assoc();
        if($user["pwd"] == hash("sha256", $pwd)){
            echo "utente trovato";
            $cred[
                "doc" -> "0",
                "st" -> "0",
                "gen" -> "0",
                "per" -> "0"
            ];
            foreach($cred as $ket => $value){
                if($cred[$key] != NULL){
                    $value = "1";
                    echo <br>"credenziali ".$key;
                }else{
                    echo <br>"non hai credenziali ".$key;
                }
            }

        }else{
            echo "password errato";
        }
    }else{
        echo "utente non trovato";
    }
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form action="" method="POST">
        <label for="name">inserisci username</label>
        <input type="text" name="name" placeholder="Enter your name">
        <br><br>
        <label for="pwd">inserisci password</label>
        <input type="password" name="pwd">
        <br><br>
        <input type="submit" text="invia">
    </form>
</body>
</html>