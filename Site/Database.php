<?php
class BaddyRPGDatabase {
    const myServer = "192.168.25.50";
	const myUser = "SQLAdmin";
	const myPass = "123456";
	const myDB = "PocketQueue";
	private $connection;
	
	public function __construct(){
		$connectionInfo = array(
			"UID" => static::myUser,
			"PWD" => static::myPass,
			"Database" => static::myDB
		);
		$this->connection = sqlsrv_connect(static::myServer, $connectionInfo);
	}
	
	public function query($query, array $args){
		
		$refArgs = array();
		foreach($args as $arg){
			$refArgs[] = &$arg;
		}
		
		$returnStatement = sqlsrv_query($this->connection, $query, $refArgs);
		
		if ($returnStatement === false){
			throw new Exception("ERROR");
		}
		
		$rows = array();
		
		while ($row = sqlsrv_fetch_array($returnStatement, SQLSRV_FETCH_ASSOC)){
			$rows[] = $row;
		}
		
		return $rows;
	}
}

$DB = new BaddyRPGDatabase();
?>